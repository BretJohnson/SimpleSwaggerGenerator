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

namespace AutoRest.CSharp.Templates.Rest.Common
{
using System;
using System.Collections.Generic;

#line 2 "ModelTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 3 "ModelTemplate.cshtml"
using System.Runtime.Remoting.Messaging;

#line default
#line hidden

#line 4 "ModelTemplate.cshtml"
using AutoRest.Core;

#line default
#line hidden

#line 5 "ModelTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden

#line 6 "ModelTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 7 "ModelTemplate.cshtml"
using AutoRest.CSharp;

#line default
#line hidden

#line 8 "ModelTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden

#line 9 "ModelTemplate.cshtml"
using AutoRest.Extensions;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class ModelTemplate : Template<global::AutoRest.CSharp.Model.CompositeTypeCs>
{

#line hidden

public override void Execute()
{

#line 11 "ModelTemplate.cshtml"
Write(Header("// "));


#line default
#line hidden
WriteLiteral("\n");


#line 12 "ModelTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 13 "ModelTemplate.cshtml"
      Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral(".");


#line 13 "ModelTemplate.cshtml"
                            Write(Settings.ModelsName);


#line default
#line hidden
WriteLiteral("\n{\n    using System.Linq;\n");


#line 16 "ModelTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n");


#line 18 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.Summary) || !string.IsNullOrWhiteSpace(Model.Documentation))
{


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// <summary>\n");

WriteLiteral("    ");


#line 21 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", (string.IsNullOrEmpty(Model.Summary) ? Model.Documentation : Model.Summary).EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 22 "ModelTemplate.cshtml"
        if (!string.IsNullOrEmpty(Model.ExternalDocsUrl))
        {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// <see href=\"");


#line 24 "ModelTemplate.cshtml"
                Write(Model.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 25 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// </summary>\n");


#line 27 "ModelTemplate.cshtml"
}


#line default
#line hidden

#line 28 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.Summary) && !string.IsNullOrWhiteSpace(Model.Documentation))
{


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// <remarks>\n");

WriteLiteral("    ");


#line 31 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("/// </remarks>\n");


#line 33 "ModelTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("\n");


#line 35 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 35 "ModelTemplate.cshtml"
     if (Model.NeedsPolymorphicConverter)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("[Newtonsoft.Json.JsonObject(\"");


#line 37 "ModelTemplate.cshtml"
                              Write(Model.SerializedName);


#line default
#line hidden
WriteLiteral("\")]\n");


#line 38 "ModelTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("\n");


#line 40 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 40 "ModelTemplate.cshtml"
     if (Model.NeedsTransformationConverter)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("[Microsoft.Rest.Serialization.JsonTransformation]\n");


#line 43 "ModelTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("\n    public partial class ");


#line 45 "ModelTemplate.cshtml"
                    Write(Model.Name);


#line default
#line hidden

#line 45 "ModelTemplate.cshtml"
                                Write(Model.BaseModelType != null ? " : " + Model.BaseModelType.Name : "");


#line default
#line hidden
WriteLiteral("\n    {\n        /// <summary>\n");

WriteLiteral("        ");


#line 48 "ModelTemplate.cshtml"
   Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n        /// </summary>\n");


#line 50 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 50 "ModelTemplate.cshtml"
         if (Model.Properties.Any(p => p.ModelType is CompositeType && ((CompositeType)p.ModelType).ContainsConstantProperties))
        {


#line default
#line hidden
WriteLiteral("\n        public ");


#line 53 "ModelTemplate.cshtml"
           Write(Model.Name);


#line default
#line hidden
WriteLiteral("()\n        {\n");


#line 55 "ModelTemplate.cshtml"
            

#line default
#line hidden

#line 55 "ModelTemplate.cshtml"
             foreach(var property in Model.ComposedProperties.Where(p => p.ModelType is CompositeType
                && !p.IsConstant
                && p.IsRequired
                && ((CompositeType)p.ModelType).ContainsConstantProperties))
            {


#line default
#line hidden
WriteLiteral("            ");


#line 60 "ModelTemplate.cshtml"
          Write(property.Name);


#line default
#line hidden
WriteLiteral(" = new ");


#line 60 "ModelTemplate.cshtml"
                                 Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral("();\n");


#line 61 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        }\n");

WriteLiteral("\n");


#line 64 "ModelTemplate.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("public ");


#line 67 "ModelTemplate.cshtml"
             Write(Model.Name);


#line default
#line hidden
WriteLiteral("() { }\n");


#line 68 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");


#line 70 "ModelTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n\n");


#line 72 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 72 "ModelTemplate.cshtml"
         if (!string.IsNullOrEmpty(Model.ConstructorParameters))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");


#line 75 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");


#line 77 "ModelTemplate.cshtml"
        foreach (var parameter in Model.ConstructorParametersDocumentation)
        {


#line default
#line hidden
WriteLiteral("        ");


#line 79 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", parameter));


#line default
#line hidden
WriteLiteral("\n");


#line 80 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("public ");


#line 81 "ModelTemplate.cshtml"
             Write(Model.Name);


#line default
#line hidden
WriteLiteral("(");


#line 81 "ModelTemplate.cshtml"
                          Write(Model.ConstructorParameters);


#line default
#line hidden
WriteLiteral(")\n");


#line 82 "ModelTemplate.cshtml"
            if (!string.IsNullOrEmpty(Model.BaseConstructorCall))
            {


#line default
#line hidden
WriteLiteral("            ");


#line 84 "ModelTemplate.cshtml"
          Write(Model.BaseConstructorCall);


#line default
#line hidden
WriteLiteral("\n");


#line 85 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("{\n");


#line 87 "ModelTemplate.cshtml"

            foreach (var property in Model.ComposedProperties.Where(p => p.ModelType is CompositeType
                     && !p.IsConstant
                     && p.IsRequired
                     && ((CompositeType)p.ModelType).ContainsConstantProperties))
            {


#line default
#line hidden
WriteLiteral("            ");


#line 93 "ModelTemplate.cshtml"
          Write(property.Name);


#line default
#line hidden
WriteLiteral(" = new ");


#line 93 "ModelTemplate.cshtml"
                                 Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral("();\n");


#line 94 "ModelTemplate.cshtml"
            }

            foreach (var property in Model.Properties.Where(p => !p.IsConstant))
            {
                var propName = CodeNamer.Instance.CamelCase(property.Name);
                if (property.Name.Value.Equals(propName))
                {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.");


#line 101 "ModelTemplate.cshtml"
               Write(property.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 101 "ModelTemplate.cshtml"
                                 Write(propName);


#line default
#line hidden
WriteLiteral(";\n");


#line 102 "ModelTemplate.cshtml"
                }
                else
                {


#line default
#line hidden
WriteLiteral("            ");


#line 105 "ModelTemplate.cshtml"
          Write(property.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 105 "ModelTemplate.cshtml"
                            Write(propName);


#line default
#line hidden
WriteLiteral(";\n");


#line 106 "ModelTemplate.cshtml"
                }
            }            



#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("}\n");


#line 110 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");


#line 112 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 112 "ModelTemplate.cshtml"
         if (Model.Properties.Any(p => p.IsConstant))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");


#line 115 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Static constructor for " + Model.Name + " class.").EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");

WriteLiteral("        ");

WriteLiteral("static ");


#line 117 "ModelTemplate.cshtml"
             Write(Model.Name);


#line default
#line hidden
WriteLiteral("()\n");

WriteLiteral("        ");

WriteLiteral("{\n");


#line 119 "ModelTemplate.cshtml"
            foreach (var property in Model.Properties.Where(p => p.IsConstant))
            {


#line default
#line hidden
WriteLiteral("            ");


#line 121 "ModelTemplate.cshtml"
          Write(property.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 121 "ModelTemplate.cshtml"
                             Write(property.DefaultValue);


#line default
#line hidden
WriteLiteral(";\n");


#line 122 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("}\n");


#line 124 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");


#line 126 "ModelTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 127 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 127 "ModelTemplate.cshtml"
         foreach (var property in Model.Properties.Where(p => !p.IsConstant))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");


#line 130 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.GetFormattedPropertySummary()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");


#line 132 "ModelTemplate.cshtml"
            if(!string.IsNullOrEmpty(property.Summary) && !string.IsNullOrEmpty(property.Documentation))
            { 


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <remarks>\n");

WriteLiteral("        ");


#line 135 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </remarks>\n");


#line 137 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.Date))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateJsonConver" +
"ter))]\n");


#line 141 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.DateTimeRfc1123))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc112" +
"3JsonConverter))]\n");


#line 145 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.Base64Url))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.Base64UrlJsonC" +
"onverter))]\n");


#line 149 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.UnixTime))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.UnixTimeJsonCo" +
"nverter))]\n");


#line 153 "ModelTemplate.cshtml"
            }

            if (property.ModelType is DictionaryType && (property.ModelType as DictionaryType).SupportsAdditionalProperties)
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonExtensionData]\n");


#line 158 "ModelTemplate.cshtml"
            }
            else
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonProperty(PropertyName = \"");


#line 161 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);


#line default
#line hidden
WriteLiteral("\")]\n");


#line 162 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("public ");


#line 163 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 163 "ModelTemplate.cshtml"
                                    Write(property.Name);


#line default
#line hidden
WriteLiteral(" { get; ");


#line 163 "ModelTemplate.cshtml"
                                                           Write(property.IsReadOnly ? "protected " : "");


#line default
#line hidden
WriteLiteral("set; }\n");


#line 164 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 164 "ModelTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 164 "ModelTemplate.cshtml"
                  
        }


#line default
#line hidden
WriteLiteral("\n");


#line 167 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 167 "ModelTemplate.cshtml"
         foreach (var property in Model.Properties.Where(p => p.IsConstant))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");


#line 170 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");


#line 172 "ModelTemplate.cshtml"
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.Date))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(DateJsonConverter))]\n");


#line 175 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.DateTimeRfc1123))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(DateTimeRfc1123JsonConverter))]\n");


#line 179 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.Base64Url))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Base64UrlJsonConverter))]\n");


#line 183 "ModelTemplate.cshtml"
            }
            if (property.ModelType.IsPrimaryType(KnownPrimaryType.UnixTime))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(UnixTimeJsonConverter))]\n");


#line 187 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[Newtonsoft.Json.JsonProperty(PropertyName = \"");


#line 188 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);


#line default
#line hidden
WriteLiteral("\")]\n");

WriteLiteral("        ");

WriteLiteral("public static ");


#line 189 "ModelTemplate.cshtml"
                   Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 189 "ModelTemplate.cshtml"
                                           Write(property.Name);


#line default
#line hidden
WriteLiteral(" { get; private set; }\n");


#line 190 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 190 "ModelTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 190 "ModelTemplate.cshtml"
                  
        }


#line default
#line hidden

#line 192 "ModelTemplate.cshtml"
 if(@Model.ShouldValidateChain())
{


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");

WriteLiteral("/// Validate the object.\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");

WriteLiteral("        ");

WriteLiteral("/// <exception cref=\"Microsoft.Rest.ValidationException\">\n");

WriteLiteral("        ");

WriteLiteral("/// Thrown if validation fails\n");

WriteLiteral("        ");

WriteLiteral("/// </exception>\n");

WriteLiteral("        ");

WriteLiteral("public ");


#line 200 "ModelTemplate.cshtml"
            Write(Model.MethodQualifier);


#line default
#line hidden
WriteLiteral(" void Validate()\n");

WriteLiteral("        ");

WriteLiteral("{\n");


#line 202 "ModelTemplate.cshtml"
            bool anythingToValidate = false;

            if (Model.BaseModelType != null && Model.BaseModelType.ShouldValidateChain())
            {
                anythingToValidate = true;


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("base.Validate();\n");


#line 208 "ModelTemplate.cshtml"
            }

            foreach (PropertyCs property in Model.Properties.Where(p => p.IsRequired && !p.IsReadOnly && !p.IsConstant && p.IsNullable() ))
            {
                anythingToValidate = true;


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("if (");


#line 213 "ModelTemplate.cshtml"
             Write(property.Name);


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("            ");

WriteLiteral("{\n");

WriteLiteral("                ");

WriteLiteral("throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Canno" +
"tBeNull, \"");


#line 215 "ModelTemplate.cshtml"
                                                                                                        Write(property.Name);


#line default
#line hidden
WriteLiteral("\");\n");

WriteLiteral("            ");

WriteLiteral("}\n");

WriteLiteral("            ");

WriteLiteral("\n");


#line 218 "ModelTemplate.cshtml"
            }
            foreach (var property in Model.Properties.Where(p => !p.IsConstant 
                && (p.Constraints.Any() || !(p.ModelType is PrimaryType))))
            {
                anythingToValidate = true;


#line default
#line hidden
WriteLiteral("            ");


#line 223 "ModelTemplate.cshtml"
         Write(property.ModelType.ValidateType(Model, $"this.{property.Name}", property.Constraints));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("            ");

WriteLiteral("\n");


#line 225 "ModelTemplate.cshtml"
            }
            if (!anythingToValidate)
            {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("//Nothing to validate\n");


#line 229 "ModelTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("}\n");


#line 231 "ModelTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("\n");


#line 233 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 233 "ModelTemplate.cshtml"
     if (Model.CodeModel.ShouldGenerateXmlSerialization) {

#line default
#line hidden
WriteLiteral("\r\n        /// <summary>\r\n        /// Serializes the object to an XML node\r\n      " +
"  /// </summary>\r\n        internal System.Xml.Linq.XElement XmlSerialize(System." +
"Xml.Linq.XElement result)\r\n        {");

WriteLiteral("\r\n");


#line 239 "ModelTemplate.cshtml"
        foreach(var property in Model.Properties.Where(p => !p.IsConstant && !p.WasFlattened())) {

#line default
#line hidden
WriteLiteral("\r\n");


#line 240 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 240 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden
WriteLiteral("\r\n            if( null != ");


#line 241 "ModelTemplate.cshtml"
                    Write(property.Name);


#line default
#line hidden
WriteLiteral(" ) \r\n            {");


#line 242 "ModelTemplate.cshtml"
                    }


#line default
#line hidden
WriteLiteral("                ");


#line 243 "ModelTemplate.cshtml"
                 if (property.ModelType is CompositeType) {

#line default
#line hidden
WriteLiteral("\r\n                result.Add(");


#line 244 "ModelTemplate.cshtml"
                       Write(property.Name);


#line default
#line hidden
WriteLiteral(".XmlSerialize(new System.Xml.Linq.XElement( \"");


#line 244 "ModelTemplate.cshtml"
                                                                                    Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\" )));");

WriteLiteral("\n");


#line 245 "ModelTemplate.cshtml"
                }
                else if (property.ModelType is DictionaryType)
                {
                    var vt = ((DictionaryType)property.ModelType).ValueType;
                    if (vt is DictionaryType || vt is SequenceType)
                    {
                        // todo: nothing right now.
                    } else if (vt is CompositeType) {

#line default
#line hidden
WriteLiteral("\r\n                var dict = new System.Xml.Linq.XElement(\"");


#line 253 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\");\r\n                foreach( var key in ");


#line 254 "ModelTemplate.cshtml"
                                Write(property.Name);


#line default
#line hidden
WriteLiteral(".Keys ) {\r\n                    dict.Add(");


#line 255 "ModelTemplate.cshtml"
                         Write(property.Name);


#line default
#line hidden
WriteLiteral("[key].XmlSerialize(new System.Xml.Linq.XElement(key) ) );\r\n                }\r\n   " +
"             result.Add(dict);");

WriteLiteral("\r\n");


#line 258 "ModelTemplate.cshtml"
                } else {

#line default
#line hidden
WriteLiteral("\r\n                var dict = new System.Xml.Linq.XElement(\"");


#line 259 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\");\r\n                foreach( var key in ");


#line 260 "ModelTemplate.cshtml"
                                Write(property.Name);


#line default
#line hidden
WriteLiteral(".Keys ){\r\n                    dict.Add(new System.Xml.Linq.XElement( key, ");


#line 261 "ModelTemplate.cshtml"
                                                            Write(property.Name);


#line default
#line hidden
WriteLiteral("[key] ) );\r\n                }\r\n                result.Add(dict);");


#line 263 "ModelTemplate.cshtml"
                                        }
                }
                else if (property.ModelType is SequenceType)
                {
                    var et = ((SequenceType)property.ModelType).ElementType;
                    if (et is DictionaryType || et is SequenceType)
                    {
                        // todo: nothing right now.
                    } else if (et is CompositeType) {if ((property.ModelType as SequenceType).XmlIsWrapped) {

#line default
#line hidden
WriteLiteral("\r\n                var seq = new System.Xml.Linq.XElement(\"");


#line 272 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\");\r\n                foreach( var value in ");


#line 273 "ModelTemplate.cshtml"
                                  Write(property.Name);


#line default
#line hidden
WriteLiteral(" ){\r\n                    seq.Add(value.XmlSerialize( new System.Xml.Linq.XElement" +
"( \"");


#line 274 "ModelTemplate.cshtml"
                                                                           Write((property.ModelType as SequenceType).ElementXmlName);


#line default
#line hidden
WriteLiteral("\") ) );\r\n                }\r\n                result.Add(seq);");


#line 276 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden
WriteLiteral("\r\n                foreach( var value in ");


#line 278 "ModelTemplate.cshtml"
                                  Write(property.Name);


#line default
#line hidden
WriteLiteral(" ){\r\n                    result.Add(value.XmlSerialize( new System.Xml.Linq.XElem" +
"ent( \"");


#line 279 "ModelTemplate.cshtml"
                                                                             Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\") ) );\r\n                }");


#line 280 "ModelTemplate.cshtml"
                        }} else {if ((property.ModelType as SequenceType).XmlIsWrapped) {

#line default
#line hidden
WriteLiteral("\r\n                var seq = new System.Xml.Linq.XElement(\"");


#line 281 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\");\r\n                foreach( var value in ");


#line 282 "ModelTemplate.cshtml"
                                  Write(property.Name);


#line default
#line hidden
WriteLiteral(" ){\r\n                    seq.Add(new System.Xml.Linq.XElement( \"");


#line 283 "ModelTemplate.cshtml"
                                                       Write((property.ModelType as SequenceType).ElementXmlName);


#line default
#line hidden
WriteLiteral("\", value ) );\r\n                }\n                result.Add(seq);");


#line 285 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden
WriteLiteral("\r\n                foreach( var value in ");


#line 287 "ModelTemplate.cshtml"
                                  Write(property.Name);


#line default
#line hidden
WriteLiteral(" ){\r\n                    result.Add(new System.Xml.Linq.XElement( \"");


#line 288 "ModelTemplate.cshtml"
                                                         Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", value ) );\r\n                }");


#line 289 "ModelTemplate.cshtml"
                        }}
                } else if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {
                    // serialize it as a enum type.
                    if (property.XmlIsAttribute) {

#line default
#line hidden
WriteLiteral("\n                result.Add(new System.Xml.Linq.XAttribute(\"");


#line 293 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", ");


#line 293 "ModelTemplate.cshtml"
                                                                           Write(property.Name);


#line default
#line hidden
WriteLiteral(".ToSerializedValue()) );");

WriteLiteral("\n");


#line 294 "ModelTemplate.cshtml"
                    } else {

#line default
#line hidden
WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");


#line 295 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", ");


#line 295 "ModelTemplate.cshtml"
                                                                         Write(property.Name);


#line default
#line hidden
WriteLiteral(".ToSerializedValue()) );");

WriteLiteral("\n");


#line 296 "ModelTemplate.cshtml"
                    }
                } else {
                    // serialize it as a primitive/value type.
                    var primitiveExpression = property.Name;
                    var knownType = (property.ModelType as PrimaryType)?.KnownPrimaryType;
                    if (knownType == KnownPrimaryType.DateTimeRfc1123)
                    {
                        primitiveExpression = property.IsNullable()
                            ? $"{primitiveExpression}?.ToUniversalTime().ToString(\"R\")"
                            : $"{primitiveExpression}.ToUniversalTime().ToString(\"R\")";
                    }
                    if (property.XmlIsAttribute) {

#line default
#line hidden
WriteLiteral("\r\n                result.Add(new System.Xml.Linq.XAttribute(\"");


#line 308 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", ");


#line 308 "ModelTemplate.cshtml"
                                                                           Write(primitiveExpression);


#line default
#line hidden
WriteLiteral(") );");

WriteLiteral("\n");


#line 309 "ModelTemplate.cshtml"
                    } else {

#line default
#line hidden
WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");


#line 310 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", ");


#line 310 "ModelTemplate.cshtml"
                                                                         Write(primitiveExpression);


#line default
#line hidden
WriteLiteral(") );");

WriteLiteral("\n");


#line 311 "ModelTemplate.cshtml"
                    }
                }


#line default
#line hidden
WriteLiteral("        ");


#line 313 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden
WriteLiteral("\r\n            }\r\n        ");


#line 315 "ModelTemplate.cshtml"
               }


#line default
#line hidden
WriteLiteral("    ");


#line 316 "ModelTemplate.cshtml"
           }


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("\r\n            return result;\r\n        }\r\n\r\n        /// <summary>\r\n        /// Des" +
"erializes an XML node to an instance of ");


#line 322 "ModelTemplate.cshtml"
                                                  Write(Model.Name);


#line default
#line hidden
WriteLiteral("\r\n        /// </summary>\n        internal static ");


#line 324 "ModelTemplate.cshtml"
                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" XmlDeserialize(string payload) \n        {\n            // deserialize to xml and " +
"use the overload to do the work\n            return XmlDeserialize( System.Xml.Li" +
"nq.XElement.Parse( payload ) );\n        }    \n\n        internal static ");


#line 330 "ModelTemplate.cshtml"
                   Write(Model.Name);


#line default
#line hidden
WriteLiteral(" XmlDeserialize(System.Xml.Linq.XElement payload) \n        {\n            var resu" +
"lt = new ");


#line 332 "ModelTemplate.cshtml"
                         Write(Model.Name);


#line default
#line hidden
WriteLiteral("();\n");


#line 333 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 333 "ModelTemplate.cshtml"
         if (Model.Properties.Any(p => !p.IsConstant && !p.WasFlattened() && p.XmlIsAttribute)) {

#line default
#line hidden
WriteLiteral("\r\n            System.Xml.Linq.XAttribute attribute;");

WriteLiteral("\n");


#line 335 "ModelTemplate.cshtml"
        }
        

#line default
#line hidden

#line 338 "ModelTemplate.cshtml"
           


#line default
#line hidden
WriteLiteral("\n");


#line 340 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 340 "ModelTemplate.cshtml"
         foreach(var property in Model.Properties.Where(p => !p.IsConstant && !p.WasFlattened())) {
            if (property.XmlIsAttribute) {

#line default
#line hidden
WriteLiteral("\r\n            if( null != (attribute = payload.Attribute(\"");


#line 342 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\")))\r\n            {\r\n");


#line 344 "ModelTemplate.cshtml"
                

#line default
#line hidden

#line 344 "ModelTemplate.cshtml"
                 if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {

#line default
#line hidden
WriteLiteral("\r\n                \r\n                result.");


#line 346 "ModelTemplate.cshtml"
                   Write(property.Name);


#line default
#line hidden
WriteLiteral(" =attribute.Value.Parse");


#line 346 "ModelTemplate.cshtml"
                                                          Write(property.ModelType.Name);


#line default
#line hidden
WriteLiteral("();\r\n                \r\n                ");


#line 348 "ModelTemplate.cshtml"
                       } else {

#line default
#line hidden
WriteLiteral(" \r\n                result.");


#line 349 "ModelTemplate.cshtml"
                   Write(property.Name);


#line default
#line hidden
WriteLiteral(" = (");


#line 349 "ModelTemplate.cshtml"
                                      Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral(")attribute;\r\n                ");


#line 350 "ModelTemplate.cshtml"
                       }


#line default
#line hidden
WriteLiteral("            }\r\n            ");

WriteLiteral("\n");


#line 353 "ModelTemplate.cshtml"
                continue;
            }
            
            var deserializerName = $"deserialize{property.Name}";
            var resultName = $"result{property.Name}";



#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("\r\n            var ");


#line 360 "ModelTemplate.cshtml"
            Write(deserializerName);


#line default
#line hidden
WriteLiteral(" = (XmlSerialization.GenerateDeserializer(Model.CodeModel, property.ModelType, pr" +
"operty.ModelTypeName));\r\n");

WriteLiteral("            ");


#line 361 "ModelTemplate.cshtml"
       Write(property.ModelTypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 361 "ModelTemplate.cshtml"
                                Write(resultName);


#line default
#line hidden
WriteLiteral(";\r\n            if (");


#line 362 "ModelTemplate.cshtml"
            Write(deserializerName);


#line default
#line hidden
WriteLiteral("(payload, \"");


#line 362 "ModelTemplate.cshtml"
                                         Write(property.XmlName);


#line default
#line hidden
WriteLiteral("\", out ");


#line 362 "ModelTemplate.cshtml"
                                                                  Write(resultName);


#line default
#line hidden
WriteLiteral("))\r\n            {\r\n                result.");


#line 364 "ModelTemplate.cshtml"
                   Write(property.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 364 "ModelTemplate.cshtml"
                                      Write(resultName);


#line default
#line hidden
WriteLiteral(";\r\n            }");

WriteLiteral("\n");


#line 366 "ModelTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("            return result;\n        } \n    ");


#line 369 "ModelTemplate.cshtml"
           }


#line default
#line hidden
WriteLiteral("    \n    }\n}\n");

}
}
}
#pragma warning restore 1591
