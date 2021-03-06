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

#line 4 "SimpleAuthMethodTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;

#line 3 "SimpleAuthMethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 2 "SimpleAuthMethodTemplate.cshtml"
using System.Globalization;

#line default
#line hidden

#line 5 "SimpleAuthMethodTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden

#line 6 "SimpleAuthMethodTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 7 "SimpleAuthMethodTemplate.cshtml"
using AutoRest.CSharp;

#line default
#line hidden

#line 8 "SimpleAuthMethodTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden

#line 9 "SimpleAuthMethodTemplate.cshtml"
using AutoRest.Extensions;

#line default
#line hidden

#line 10 "SimpleAuthMethodTemplate.cshtml"
using System.Xml;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class SimpleAuthMethodTemplate : AutoRest.Core.Template<Tuple<AutoRest.CSharp.Model.MethodCs,bool>>
{

#line hidden

public override void Execute()
{

#line 13 "SimpleAuthMethodTemplate.cshtml"
 if (!string.IsNullOrWhiteSpace(Model.Item1.Description) || !string.IsNullOrEmpty(Model.Item1.Summary))
{


#line default
#line hidden
WriteLiteral("/// <summary>\n");


#line 16 "SimpleAuthMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Item1.Summary) ? Model.Item1.Description.EscapeXmlComment() : Model.Item1.Summary.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 17 "SimpleAuthMethodTemplate.cshtml"
    if (!string.IsNullOrEmpty(Model.Item1.ExternalDocsUrl))
    {


#line default
#line hidden
WriteLiteral("/// <see href=\"");


#line 19 "SimpleAuthMethodTemplate.cshtml"
            Write(Model.Item1.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 20 "SimpleAuthMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("/// </summary>\n");


#line 22 "SimpleAuthMethodTemplate.cshtml"
}


#line default
#line hidden

#line 23 "SimpleAuthMethodTemplate.cshtml"
 if (!String.IsNullOrEmpty(Model.Item1.Description) && !String.IsNullOrEmpty(Model.Item1.Summary))
{


#line default
#line hidden
WriteLiteral("/// <remarks>\n");


#line 26 "SimpleAuthMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Item1.Description.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </remarks>\n");


#line 28 "SimpleAuthMethodTemplate.cshtml"
}


#line default
#line hidden

#line 29 "SimpleAuthMethodTemplate.cshtml"
 foreach (var parameter in Model.Item1.LocalParameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 31 "SimpleAuthMethodTemplate.cshtml"
              Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\'>\n");


#line 32 "SimpleAuthMethodTemplate.cshtml"


#line default
#line hidden

#line 32 "SimpleAuthMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 34 "SimpleAuthMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("\n");


#line 36 "SimpleAuthMethodTemplate.cshtml"
 if (Model.Item1.Deprecated)
{


#line default
#line hidden
WriteLiteral("[System.Obsolete()]\n");


#line 39 "SimpleAuthMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("public ");


#line 40 "SimpleAuthMethodTemplate.cshtml"
   Write(Model.Item1.TaskExtensionReturnTypeString);


#line default
#line hidden
WriteLiteral(" ");


#line 40 "SimpleAuthMethodTemplate.cshtml"
                                                Write(Model.Item1.Name);


#line default
#line hidden
WriteLiteral("(");


#line 40 "SimpleAuthMethodTemplate.cshtml"
                                                                    Write(Model.Item1.GetAsyncMethodParameterDeclaration(true));


#line default
#line hidden
WriteLiteral(")\n{\n");


#line 42 "SimpleAuthMethodTemplate.cshtml"
 

#line default
#line hidden

#line 42 "SimpleAuthMethodTemplate.cshtml"
  foreach (ParameterCs parameter in Model.Item1.Parameters.Where(p => !p.IsConstant))
    {
        if (parameter.IsRequired && parameter.IsNullable())
        {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("if (");


#line 46 "SimpleAuthMethodTemplate.cshtml"
      Write(parameter.Name);


#line default
#line hidden
WriteLiteral(" == null)\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("        ");

WriteLiteral("throw new System.Exception(\"Parameter \'");


#line 48 "SimpleAuthMethodTemplate.cshtml"
                                             Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\' cannot be null\");\n");

WriteLiteral("    ");

WriteLiteral("}\n");

WriteLiteral("\n");


#line 51 "SimpleAuthMethodTemplate.cshtml"
        }
        if(parameter.CanBeValidated  && (Model.Item1.HttpMethod != HttpMethod.Patch || parameter.Location != ParameterLocation.Body))
        {


#line default
#line hidden
WriteLiteral("    ");


#line 54 "SimpleAuthMethodTemplate.cshtml"
  Write(parameter.ModelType.ValidateType(Model.Item1, parameter.Name, parameter.Constraints));


#line default
#line hidden
WriteLiteral("\n");


#line 55 "SimpleAuthMethodTemplate.cshtml"
        }
    }


#line default
#line hidden
WriteLiteral("\n    var path = \"");


#line 58 "SimpleAuthMethodTemplate.cshtml"
            Write(Model.Item1.Url);


#line default
#line hidden
WriteLiteral("\";\n\n");

WriteLiteral("    ");


#line 60 "SimpleAuthMethodTemplate.cshtml"
Write(Model.Item1.BuildBody(@Model.Item2));


#line default
#line hidden
WriteLiteral("\n\n\n}");

}
}
}
#pragma warning restore 1591
