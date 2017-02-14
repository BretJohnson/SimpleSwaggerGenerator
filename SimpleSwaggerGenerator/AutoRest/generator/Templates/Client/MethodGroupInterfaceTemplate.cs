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

#line 2 "MethodGroupInterfaceTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;

#line 3 "MethodGroupInterfaceTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 4 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 5 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.CSharp;

#line default
#line hidden

#line 6 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class MethodGroupInterfaceTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodGroupCs>
{

#line hidden

public override void Execute()
{

#line 8 "MethodGroupInterfaceTemplate.cshtml"
Write(Header("// "));


#line default
#line hidden
WriteLiteral("\n");


#line 9 "MethodGroupInterfaceTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 10 "MethodGroupInterfaceTemplate.cshtml"
     Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral("\n{\n");


#line 12 "MethodGroupInterfaceTemplate.cshtml"
 foreach (var usingString in Model.Usings) {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using ");


#line 13 "MethodGroupInterfaceTemplate.cshtml"
       Write(usingString);


#line default
#line hidden
WriteLiteral(";\n");


#line 14 "MethodGroupInterfaceTemplate.cshtml"
}


#line default
#line hidden

#line 15 "MethodGroupInterfaceTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n    /// <summary>\n    /// ");


#line 17 "MethodGroupInterfaceTemplate.cshtml"
    Write(Model.TypeName);


#line default
#line hidden
WriteLiteral(" operations.\n    /// </summary>\n    public partial interface I");


#line 19 "MethodGroupInterfaceTemplate.cshtml"
                          Write(Model.TypeName);


#line default
#line hidden
WriteLiteral("\n    {\n");


#line 21 "MethodGroupInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 21 "MethodGroupInterfaceTemplate.cshtml"
     foreach(MethodCs method in Model.Methods)
    {
        if (!String.IsNullOrEmpty(method.Description) || !String.IsNullOrEmpty(method.Summary))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");


#line 26 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", String.IsNullOrEmpty(method.Summary) ? method.Description.EscapeXmlComment() : method.Summary.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 27 "MethodGroupInterfaceTemplate.cshtml"
            if (!String.IsNullOrEmpty(method.ExternalDocsUrl))
            {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <see href=\"");


#line 29 "MethodGroupInterfaceTemplate.cshtml"
                    Write(method.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 30 "MethodGroupInterfaceTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// </summary>\n");


#line 32 "MethodGroupInterfaceTemplate.cshtml"
        }
        if (!String.IsNullOrEmpty(method.Description) && !String.IsNullOrEmpty(method.Summary))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <remarks>\n");

WriteLiteral("        ");


#line 36 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", method.Description.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </remarks>\n");


#line 38 "MethodGroupInterfaceTemplate.cshtml"
        }
        foreach (ParameterCs parameter in method.LocalParameters)
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <param name=\'");


#line 41 "MethodGroupInterfaceTemplate.cshtml"
                      Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\'>\n");

WriteLiteral("        ");


#line 42 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", parameter.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("        ");

WriteLiteral("/// </param>\n");


#line 44 "MethodGroupInterfaceTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <param name=\'customHeaders\'>\n");

WriteLiteral("        ");

WriteLiteral("/// The headers that will be added to request.\n");

WriteLiteral("        ");

WriteLiteral("/// </param>\n");

WriteLiteral("        ");

WriteLiteral("/// <param name=\'cancellationToken\'>\n");

WriteLiteral("        ");

WriteLiteral("/// The cancellation token.\n");

WriteLiteral("        ");

WriteLiteral("/// </param>\n");

WriteLiteral("        ");

WriteLiteral("/// <exception cref=\"");


#line 51 "MethodGroupInterfaceTemplate.cshtml"
                           Write(method.OperationExceptionTypeString);


#line default
#line hidden
WriteLiteral("\">\n");

WriteLiteral("        ");

WriteLiteral("/// Thrown when the operation returned an invalid status code\n");

WriteLiteral("        ");

WriteLiteral("/// </exception>\n");


#line 54 "MethodGroupInterfaceTemplate.cshtml"
        if (method.Responses.Where(r => r.Value.Body != null).Any())
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <exception cref=\"Microsoft.Rest.SerializationException\">\n");

WriteLiteral("        ");

WriteLiteral("/// Thrown when unable to deserialize the response\n");

WriteLiteral("        ");

WriteLiteral("/// </exception>\n");


#line 59 "MethodGroupInterfaceTemplate.cshtml"
        }
        if (method.Parameters.Any(p => p.IsRequired && p.IsNullable()))
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <exception cref=\"Microsoft.Rest.ValidationException\">\n");

WriteLiteral("        ");

WriteLiteral("/// Thrown when a required parameter is null\n");

WriteLiteral("        ");

WriteLiteral("/// </exception>\n");


#line 65 "MethodGroupInterfaceTemplate.cshtml"
        }
        if (method.Deprecated)
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("[System.Obsolete()]\n");


#line 69 "MethodGroupInterfaceTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("System.Threading.Tasks.Task<");


#line 70 "MethodGroupInterfaceTemplate.cshtml"
                                 Write(method.OperationResponseReturnTypeString);


#line default
#line hidden
WriteLiteral("> ");


#line 70 "MethodGroupInterfaceTemplate.cshtml"
                                                                             Write(method.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 70 "MethodGroupInterfaceTemplate.cshtml"
                                                                                                                 Write(method.GetAsyncMethodParameterDeclaration(true));


#line default
#line hidden
WriteLiteral(");\n");


#line 71 "MethodGroupInterfaceTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("    }\n}\n");

}
}
}
#pragma warning restore 1591