#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AutoRest.CSharp.Templates.Rest.Client
{

#line 2 "ServiceClientBodyTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;

#line 3 "ServiceClientBodyTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 4 "ServiceClientBodyTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden

#line 5 "ServiceClientBodyTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class ServiceClientBodyTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.CodeModelCs>
{

#line hidden

public override void Execute()
{
WriteLiteral("\n/// <summary>\n/// The base URI of the service.\n/// </summary>\n");


#line 12 "ServiceClientBodyTemplate.cshtml"
 if(Model.IsCustomBaseUri)
{


#line default
#line hidden
WriteLiteral("internal string BaseUri {get; set;}\n");


#line 15 "ServiceClientBodyTemplate.cshtml"
}
else
{


#line default
#line hidden
WriteLiteral("public System.Uri BaseUri { get; set; }\n");


#line 19 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

#line 20 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n/// <summary>\n/// Gets or sets json serialization settings.\n/// </summary>\npubl" +
"ic Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; private s" +
"et; }\n");


#line 26 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n/// <summary>\n/// Gets or sets json deserialization settings.\n/// </summary>\npu" +
"blic Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; priva" +
"te set; }\n");


#line 32 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n        \n");


#line 34 "ServiceClientBodyTemplate.cshtml"
 foreach (var property in Model.Properties)
{


#line default
#line hidden
WriteLiteral("/// <summary>\n");


#line 37 "ServiceClientBodyTemplate.cshtml"
Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("public ");


#line 39 "ServiceClientBodyTemplate.cshtml"
    Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 39 "ServiceClientBodyTemplate.cshtml"
                            Write(property.Name);


#line default
#line hidden
WriteLiteral(" { get; ");


#line 39 "ServiceClientBodyTemplate.cshtml"
                                                   Write(property.IsReadOnly || property.IsConstant ? "private " : "");


#line default
#line hidden
WriteLiteral("set; }\n");


#line 40 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 40 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden

#line 40 "ServiceClientBodyTemplate.cshtml"
          
}


#line default
#line hidden
WriteLiteral("        \n");


#line 43 "ServiceClientBodyTemplate.cshtml"
 foreach (var operation in Model.AllOperations) 
{


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Gets the I");


#line 46 "ServiceClientBodyTemplate.cshtml"
            Write(operation.TypeName);


#line default
#line hidden
WriteLiteral(".\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("public virtual I");


#line 48 "ServiceClientBodyTemplate.cshtml"
              Write(operation.TypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 48 "ServiceClientBodyTemplate.cshtml"
                                    Write(operation.NameForProperty);


#line default
#line hidden
WriteLiteral(" { get; private set; }\n");


#line 49 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 49 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden

#line 49 "ServiceClientBodyTemplate.cshtml"
          
}


#line default
#line hidden
WriteLiteral("       \n/// <summary>\n/// Initializes a new instance of the ");


#line 53 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n/// </summary>\n/// <param");

WriteLiteral(" name=\'handlers\'");

WriteLiteral(">\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// <" +
"/param>\n");


#line 58 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 58 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);


#line default
#line hidden
WriteLiteral("(params System.Net.Http.DelegatingHandler[] handlers) : base(handlers)\n{\n    this" +
".Initialize();\n}\n");


#line 62 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");


#line 65 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n/// </summary>\n/// <param");

WriteLiteral(" name=\'rootHandler\'");

WriteLiteral(">\n/// Optional. The http client handler used to handle http transport.\n/// </para" +
"m>\n/// <param");

WriteLiteral(" name=\'handlers\'");

WriteLiteral(">\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// <" +
"/param>\n");


#line 73 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 73 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);


#line default
#line hidden
WriteLiteral("(System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.Delegating" +
"Handler[] handlers) : base(rootHandler, handlers)\n{\n    this.Initialize();\n}\n");


#line 77 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n");


#line 79 "ServiceClientBodyTemplate.cshtml"
 if(!Model.IsCustomBaseUri)
{ 


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 82 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("/// <param name=\'baseUri\'>\n");

WriteLiteral("/// Optional. The base URI of the service.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 93 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 93 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);


#line default
#line hidden
WriteLiteral("(System.Uri baseUri, params System.Net.Http.DelegatingHandler[] handlers) : this(" +
"handlers)\n");

WriteLiteral("{\n");

WriteLiteral("    if (baseUri == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"baseUri\");\n");

WriteLiteral("    }\n");

WriteLiteral("\n");

WriteLiteral("    this.BaseUri = baseUri;\n");

WriteLiteral("}\n");


#line 102 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral(" \n");


#line 103 "ServiceClientBodyTemplate.cshtml"



#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 105 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("/// <param name=\'baseUri\'>\n");

WriteLiteral("/// Optional. The base URI of the service.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <param name=\'rootHandler\'>\n");

WriteLiteral("/// Optional. The http client handler used to handle http transport.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 119 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 119 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);


#line default
#line hidden
WriteLiteral("(System.Uri baseUri, System.Net.Http.HttpClientHandler rootHandler, params System" +
".Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n");

WriteLiteral("{\n");

WriteLiteral("    if (baseUri == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"baseUri\");\n");

WriteLiteral("    }\n");

WriteLiteral("\n");

WriteLiteral("    this.BaseUri = baseUri;\n");

WriteLiteral("}\n");


#line 128 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 129 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("\n");


#line 131 "ServiceClientBodyTemplate.cshtml"
  var parameters = Model.Properties.Where(p => p.IsRequired && p.IsReadOnly);

#line default
#line hidden
WriteLiteral("\n");


#line 132 "ServiceClientBodyTemplate.cshtml"
 if (parameters.Any())
{


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 135 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");


#line 137 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 139 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\'>\n");

WriteLiteral("/// Required. ");


#line 140 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 142 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 149 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 149 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);


#line default
#line hidden
WriteLiteral("(");


#line 149 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);


#line default
#line hidden
WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n");

WriteLiteral("{\n");


#line 151 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    if (");


#line 153 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"");


#line 155 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\");\n");

WriteLiteral("    }\n");


#line 157 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    this.");


#line 160 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 160 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(";\n");


#line 161 "ServiceClientBodyTemplate.cshtml"
    if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("if (this.Credentials != null)\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    this.Credentials.InitializeServiceClient(this);\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 167 "ServiceClientBodyTemplate.cshtml"
    }
}


#line default
#line hidden
WriteLiteral("}\n");


#line 170 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 171 "ServiceClientBodyTemplate.cshtml"
        


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 173 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");


#line 175 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 177 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\'>\n");

WriteLiteral("/// Required. ");


#line 178 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 180 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'rootHandler\'>\n");

WriteLiteral("/// Optional. The http client handler used to handle http transport.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 190 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 190 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);


#line default
#line hidden
WriteLiteral("(");


#line 190 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);


#line default
#line hidden
WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.Delegatin" +
"gHandler[] handlers) : this(rootHandler, handlers)\n");

WriteLiteral("{\n");


#line 192 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    if (");


#line 194 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"");


#line 196 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\");\n");

WriteLiteral("    }\n");


#line 198 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    this.");


#line 201 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 201 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(";\n");


#line 202 "ServiceClientBodyTemplate.cshtml"
    if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("if (this.Credentials != null)\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    this.Credentials.InitializeServiceClient(this);\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 208 "ServiceClientBodyTemplate.cshtml"
    }
}


#line default
#line hidden
WriteLiteral("}\n");


#line 211 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 212 "ServiceClientBodyTemplate.cshtml"

if(!Model.IsCustomBaseUri)
{ 


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 216 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("/// <param name=\'baseUri\'>\n");

WriteLiteral("/// Optional. The base URI of the service.\n");

WriteLiteral("/// </param>\n");


#line 221 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 223 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\'>\n");

WriteLiteral("/// Required. ");


#line 224 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 226 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 233 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 233 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);


#line default
#line hidden
WriteLiteral("(System.Uri baseUri, ");


#line 233 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);


#line default
#line hidden
WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n");

WriteLiteral("{\n");

WriteLiteral("    if (baseUri == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"baseUri\");\n");

WriteLiteral("    }\n");


#line 239 "ServiceClientBodyTemplate.cshtml"
    foreach (var param in parameters)
    {


#line default
#line hidden
WriteLiteral("    if (");


#line 241 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"");


#line 243 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\");\n");

WriteLiteral("    }\n");


#line 245 "ServiceClientBodyTemplate.cshtml"
}



#line default
#line hidden
WriteLiteral("    this.BaseUri = baseUri;\n");


#line 248 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    this.");


#line 251 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 251 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(";\n");


#line 252 "ServiceClientBodyTemplate.cshtml"

if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("if (this.Credentials != null)\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    this.Credentials.InitializeServiceClient(this);\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 259 "ServiceClientBodyTemplate.cshtml"
}
}


#line default
#line hidden
WriteLiteral("}\n");


#line 262 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 263 "ServiceClientBodyTemplate.cshtml"
        


#line default
#line hidden
WriteLiteral("/// <summary>\n");

WriteLiteral("/// Initializes a new instance of the ");


#line 265 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" class.\n");

WriteLiteral("/// </summary>\n");

WriteLiteral("/// <param name=\'baseUri\'>\n");

WriteLiteral("/// Optional. The base URI of the service.\n");

WriteLiteral("/// </param>\n");


#line 270 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 272 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\'>\n");

WriteLiteral("/// Required. ");


#line 273 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 275 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'rootHandler\'>\n");

WriteLiteral("/// Optional. The http client handler used to handle http transport.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <param name=\'handlers\'>\n");

WriteLiteral("/// Optional. The delegating handlers to add to the http client pipeline.\n");

WriteLiteral("/// </param>\n");

WriteLiteral("/// <exception cref=\"System.ArgumentNullException\">\n");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("/// </exception>\n");


#line 285 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);


#line default
#line hidden
WriteLiteral(" ");


#line 285 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);


#line default
#line hidden
WriteLiteral("(System.Uri baseUri, ");


#line 285 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);


#line default
#line hidden
WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.Delegatin" +
"gHandler[] handlers) : this(rootHandler, handlers)\n");

WriteLiteral("{\n");

WriteLiteral("    if (baseUri == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"baseUri\");\n");

WriteLiteral("    }\n");


#line 291 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    if (");


#line 294 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("    {\n");

WriteLiteral("        throw new System.ArgumentNullException(\"");


#line 296 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral("\");\n");

WriteLiteral("    }\n");


#line 298 "ServiceClientBodyTemplate.cshtml"
}



#line default
#line hidden
WriteLiteral("    this.BaseUri = baseUri;\n");


#line 301 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{


#line default
#line hidden
WriteLiteral("    this.");


#line 304 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 304 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());


#line default
#line hidden
WriteLiteral(";\n");


#line 305 "ServiceClientBodyTemplate.cshtml"

if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("if (this.Credentials != null)\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    this.Credentials.InitializeServiceClient(this);\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 312 "ServiceClientBodyTemplate.cshtml"
}
}


#line default
#line hidden
WriteLiteral("}\n");


#line 315 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 316 "ServiceClientBodyTemplate.cshtml"
}
}

#line default
#line hidden
}
}
}
#pragma warning restore 1591
