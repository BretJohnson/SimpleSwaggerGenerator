// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Logging;
using AutoRest.Core.Utilities;
using AutoRest.CSharp.Model;
using AutoRest.CSharp.Templates.Rest.Client;
using AutoRest.CSharp.Templates.Rest.Common;
using static AutoRest.Core.Utilities.DependencyInjection;
using AutoRest.Extensions;
using System.Text;

namespace AutoRest.CSharp
{
    public class CodeGeneratorCs : CodeGenerator
    {
        private const string ClientRuntimePackage = "Clancey.SimpleAuth.1.0.31";

        public override bool IsSingleFileGenerationSupported => true;


        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
			SimpleSwaggerGenerator.AutoRest.generator.Properties.Resources.UsageInformation, ClientRuntimePackage);

        public override string ImplementationFileExtension => ".cs";

        private async Task GenerateServerSideCode(CodeModelCs codeModel)
        {
            //foreach (string methodGrp in codeModel.MethodGroupNames)
            //{
            //    using (NewContext)
            //    {
            //        codeModel.Name = methodGrp;
            //        // Service server
            //        var serviceControllerTemplate = new AutoRest.CSharp.Templates.Rest.Server.ServiceControllerTemplate { Model = codeModel };
            //        await Write(serviceControllerTemplate, $"{codeModel.Name}{ImplementationFileExtension}");
            //    }
            //}
            //// Models
            //foreach (CompositeTypeCs model in codeModel.ModelTypes.Union(codeModel.HeaderTypes))
            //{
            //    var modelTemplate = new ModelTemplate { Model = model };
            //    await Write(modelTemplate, Path.Combine(Settings.Instance.ModelsName, $"{model.Name}{ImplementationFileExtension}"));
            //}
        }

        private async Task<string> GenerateClientSideCode(CodeModelCs codeModel)
        {
			var sb = new StringBuilder();

			var isInMemory = Settings.Instance.OutputInMemory;

            if (!Settings.Instance.SeperateClassesIntoFiles && string.IsNullOrWhiteSpace(Settings.Instance.OutputFileName))
            {
                Settings.Instance.OutputFileName = $"{codeModel.Name}{ImplementationFileExtension}";
            }

			//TODO: Move this down to the modeler
            var apis = codeModel.SecurityDefinitions?.ToList() ?? new System.Collections.Generic.List<SecurityDefinition>();
			//Taking care of OAuthApiKey apis
			if (apis?.Count(x => x.SecuritySchemeType == SecuritySchemeType.ApiKey || x.SecuritySchemeType == SecuritySchemeType.OAuth2) == 2)
			{
				var oauth = apis.FirstOrDefault(x => x.SecuritySchemeType == SecuritySchemeType.OAuth2);
				var apikey = apis.FirstOrDefault(x => x.SecuritySchemeType == SecuritySchemeType.ApiKey);
				oauth.Name = apikey.Name;
				oauth.ApiKeyName = apikey.Name;
				oauth.In = apikey.In;
				oauth.SecuritySchemeType = SecuritySchemeType.OauthApiKey;
				apis.Remove(apikey);
			}
			if (!apis.Any())
			{
                apis.Add(new SecurityDefinition { ApiKey = "" });
			}

			
            var groups = codeModel.Operations.SelectMany(method => method.SecurityDefinitionNames.Any() ?
                                                         method.SecurityDefinitionNames.Select(x => new Tuple<string, MethodGroup>(x, method)) : new[] { new Tuple<string, MethodGroup>("", method) }).GroupBy(x => x.Item1).ToDictionary(x => x.Key, x => x.Select(y=> y.Item2).ToArray());

            var apiModels = apis.Select(x => new ApiModel { CodeModel = codeModel,
				Definition = x, 
                Operations = groups[x.ApiKey].Union(string.IsNullOrWhiteSpace(x.ApiKeyName) ? new MethodGroup[0] : groups[x.ApiKeyName]).ToArray() 
			}).ToList();

			foreach (var apiModel in apiModels)
			{
				var simpleAuthApiTemplate = new SimpleAuthApiTemplate { Model = apiModel };
				if (isInMemory)
					GenerateTemplateCode(simpleAuthApiTemplate, sb);
				else
					await Write(simpleAuthApiTemplate, $"{apiModel.Name}{ImplementationFileExtension}");

            }
           
            // Models
            foreach (CompositeTypeCs model in codeModel.ModelTypes.Union(codeModel.HeaderTypes))
            {
                if (model.Extensions.ContainsKey(SwaggerExtensions.ExternalExtension) &&
                    (bool)model.Extensions[SwaggerExtensions.ExternalExtension])
                {
                    continue;
                }

                var modelTemplate = new ModelTemplate{ Model = model };
				if (isInMemory)
					GenerateTemplateCode(modelTemplate, sb);
                else
					await Write(modelTemplate, Path.Combine(Settings.Instance.ModelsName, $"{model.Name}{ImplementationFileExtension}"));
            }

            // Enums
            foreach (EnumTypeCs enumType in codeModel.EnumTypes)
            {
                var enumTemplate = new EnumTemplate { Model = enumType };
				if (isInMemory)
					GenerateTemplateCode(enumTemplate, sb);
				else
                	await Write(enumTemplate, Path.Combine(Settings.Instance.ModelsName, $"{enumTemplate.Model.Name}{ImplementationFileExtension}"));
            }

            var extensionTemplate = new ExtensionsTemplate ();
            if (isInMemory)
                GenerateTemplateCode(extensionTemplate, sb);
            else
                await Write(extensionTemplate, Path.Combine($"{codeModel.Name}Extensions{ImplementationFileExtension}"));

			return sb.ToString();
        }

		void GenerateTemplateCode(ITemplate template, StringBuilder stringBuilder)
		{
			var lineEnding = Environment.NewLine;

			using (StringReader streamReader = new StringReader(template.ToString()))
			{
				var skipEmptyLines = true;

				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					// remove any errant line endings, and trim whitespace from the end too.
					line = line.Replace("\r", "").Replace("\n", "").TrimEnd(' ', '\r', '\n', '\t');

					if (line.Contains(TemplateConstants.EmptyLine))
					{
						stringBuilder.AppendLine(lineEnding);
					}
					else if (!skipEmptyLines || !string.IsNullOrWhiteSpace(line))
					{
						stringBuilder.AppendLine(line);
					}
				}
			}
		}


        private async Task<string> GenerateRestCode(CodeModelCs codeModel)
        {
            
			return await GenerateClientSideCode(codeModel);
		}

        /// <summary>
        /// Generates C# code for service client.
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public override Task<string> Generate(CodeModel cm)
        {
            // get c# specific codeModel
            var codeModel = cm as CodeModelCs;
            if (codeModel == null)
            {
                throw new InvalidCastException("CodeModel is not a c# CodeModel");
            }
			return GenerateClientSideCode(codeModel);
        }
    }
}
