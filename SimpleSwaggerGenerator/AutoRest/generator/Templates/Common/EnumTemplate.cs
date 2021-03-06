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

#line 2 "EnumTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 3 "EnumTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class EnumTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.EnumTypeCs>
{

#line hidden

public override void Execute()
{

#line 5 "EnumTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 6 "EnumTemplate.cshtml"
      Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral(".");


#line 6 "EnumTemplate.cshtml"
                            Write(Settings.ModelsName);


#line default
#line hidden
WriteLiteral("\n{\n");


#line 8 "EnumTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n    /// <summary>\n");

WriteLiteral("    ");


#line 10 "EnumTemplate.cshtml"
Write(WrapComment("/// ", "Defines values for " + Model.Name + "."));


#line default
#line hidden
WriteLiteral("\n    /// </summary>\n");


#line 12 "EnumTemplate.cshtml"
    

#line default
#line hidden

#line 12 "EnumTemplate.cshtml"
     if (!Model.ModelAsString)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConver" +
"ter))]\n");

WriteLiteral("    ");

WriteLiteral("public enum ");


#line 15 "EnumTemplate.cshtml"
             Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("{\n");


#line 17 "EnumTemplate.cshtml"
        for (int i = 0; i < Model.Values.Count - 1; i++)
        {


#line default
#line hidden
WriteLiteral("        [System.Runtime.Serialization.EnumMember(Value = \"");


#line 19 "EnumTemplate.cshtml"
                                                       Write(Model.Values[i].SerializedName);


#line default
#line hidden
WriteLiteral("\")]\n");

WriteLiteral("        ");


#line 20 "EnumTemplate.cshtml"
      Write(Model.Values[i].MemberName);


#line default
#line hidden
WriteLiteral(",\n");


#line 21 "EnumTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("        [System.Runtime.Serialization.EnumMember(Value = \"");


#line 22 "EnumTemplate.cshtml"
                                                       Write(Model.Values.Last().SerializedName);


#line default
#line hidden
WriteLiteral("\")]\n");

WriteLiteral("        ");


#line 23 "EnumTemplate.cshtml"
      Write(Model.Values.Last().MemberName);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 25 "EnumTemplate.cshtml"
    if (Model.CodeModel.ShouldGenerateXmlSerialization) {

#line default
#line hidden
WriteLiteral("\n    internal static class ");


#line 26 "EnumTemplate.cshtml"
                      Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("EnumExtension \n    {\n        internal static string ToSerializedValue(this ");


#line 28 "EnumTemplate.cshtml"
                                                  Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("? value )  => \n            value == null ? null : (( ");


#line 29 "EnumTemplate.cshtml"
                                  Write(Model.ClassName);


#line default
#line hidden
WriteLiteral(" )value).ToSerializedValue();\n");


#line 30 "EnumTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n        internal static string ToSerializedValue(this ");


#line 31 "EnumTemplate.cshtml"
                                                  Write(Model.ClassName);


#line default
#line hidden
WriteLiteral(" value ) \n        {\n            switch( value )\n            {\n");


#line 35 "EnumTemplate.cshtml"
            

#line default
#line hidden

#line 35 "EnumTemplate.cshtml"
             for (int i = 0; i < Model.Values.Count; i++)
            {

#line default
#line hidden
WriteLiteral("\n                case ");


#line 37 "EnumTemplate.cshtml"
                 Write(Model.ClassName);


#line default
#line hidden
WriteLiteral(".");


#line 37 "EnumTemplate.cshtml"
                                    Write(Model.Values[i].MemberName);


#line default
#line hidden
WriteLiteral(":\n                    return \"");


#line 38 "EnumTemplate.cshtml"
                       Write(Model.Values[i].SerializedName);


#line default
#line hidden
WriteLiteral("\";");

WriteLiteral("\n");


#line 39 "EnumTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("\n            }\n            return null;\n        }\n");


#line 44 "EnumTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n        internal static ");


#line 45 "EnumTemplate.cshtml"
                    Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("? Parse");


#line 45 "EnumTemplate.cshtml"
                                             Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("( this string value )\n        { \n            switch( value )\n            {\n");


#line 49 "EnumTemplate.cshtml"
            

#line default
#line hidden

#line 49 "EnumTemplate.cshtml"
             for (int i = 0; i < Model.Values.Count; i++)   
            {

#line default
#line hidden
WriteLiteral("\n                case \"");


#line 51 "EnumTemplate.cshtml"
                 Write(Model.Values[i].SerializedName);


#line default
#line hidden
WriteLiteral("\": \n                    return ");


#line 52 "EnumTemplate.cshtml"
                       Write(Model.ClassName);


#line default
#line hidden
WriteLiteral(".");


#line 52 "EnumTemplate.cshtml"
                                          Write(Model.Values[i].MemberName);


#line default
#line hidden
WriteLiteral(";");

WriteLiteral("\n");


#line 53 "EnumTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("            }\n            return null;\n        }\n        \n    }\n");


#line 59 "EnumTemplate.cshtml"
       }
    
    }
    else
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("public static class ");


#line 64 "EnumTemplate.cshtml"
                     Write(Model.ClassName);


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("{\n");


#line 66 "EnumTemplate.cshtml"
        foreach (var t in Model.Values)
        {


#line default
#line hidden
WriteLiteral("        public const string ");


#line 68 "EnumTemplate.cshtml"
                         Write(t.MemberName);


#line default
#line hidden
WriteLiteral(" = \"");


#line 68 "EnumTemplate.cshtml"
                                          Write(t.SerializedName);


#line default
#line hidden
WriteLiteral("\";\n");


#line 69 "EnumTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("}\n");


#line 71 "EnumTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("}\n");

}
}
}
#pragma warning restore 1591
