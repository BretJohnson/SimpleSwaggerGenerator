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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 2 "MethodGroupTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden

#line 3 "MethodGroupTemplate.cshtml"
using AutoRest.CSharp.Templates;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class MethodGroupTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodGroupCs>
{

#line hidden

public override void Execute()
{

#line 5 "MethodGroupTemplate.cshtml"
Write(Header("// "));


#line default
#line hidden
WriteLiteral("\n");


#line 6 "MethodGroupTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 7 "MethodGroupTemplate.cshtml"
     Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral("\n{\n    using System.IO;\n    using Microsoft.Rest;\n");


#line 11 "MethodGroupTemplate.cshtml"
 foreach (var usingString in Model.Usings) {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using ");


#line 12 "MethodGroupTemplate.cshtml"
       Write(usingString);


#line default
#line hidden
WriteLiteral(";\n");


#line 13 "MethodGroupTemplate.cshtml"
}


#line default
#line hidden

#line 14 "MethodGroupTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n    /// <summary>\n    /// ");


#line 16 "MethodGroupTemplate.cshtml"
    Write(Model.TypeName);


#line default
#line hidden
WriteLiteral(" operations.\n    /// </summary>\n    public partial class ");


#line 18 "MethodGroupTemplate.cshtml"
                     Write(Model.TypeName);


#line default
#line hidden
WriteLiteral(" : Microsoft.Rest.IServiceOperations<");


#line 18 "MethodGroupTemplate.cshtml"
                                                                          Write(Model.CodeModel.Name);


#line default
#line hidden
WriteLiteral(">, I");


#line 18 "MethodGroupTemplate.cshtml"
                                                                                                    Write(Model.TypeName);


#line default
#line hidden
WriteLiteral("\n    {\n        /// <summary>\n        /// Initializes a new instance of the ");


#line 21 "MethodGroupTemplate.cshtml"
                                          Write(Model.TypeName);


#line default
#line hidden
WriteLiteral(" class.\n        /// </summary>\n        /// <param");

WriteLiteral(" name=\'client\'");

WriteLiteral(">\n        /// Reference to the service client.\n        /// </param>\n        /// <" +
"exception");

WriteLiteral(" cref=\"System.ArgumentNullException\"");

WriteLiteral(">\n        /// Thrown when a required parameter is null\n        /// </exception>\n " +
"       public ");


#line 29 "MethodGroupTemplate.cshtml"
           Write(Model.TypeName);


#line default
#line hidden
WriteLiteral("(");


#line 29 "MethodGroupTemplate.cshtml"
                            Write(Model.CodeModel.Name);


#line default
#line hidden
WriteLiteral(" client)\n        {\n            if (client == null) \n            {\n               " +
" throw new System.ArgumentNullException(\"client\");\n            }\n            thi" +
"s.Client = client;\n        }\n");

WriteLiteral("        ");


#line 37 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n        /// <summary>\n        /// Gets a reference to the ");


#line 39 "MethodGroupTemplate.cshtml"
                               Write(Model.CodeModel.Name);


#line default
#line hidden
WriteLiteral("\n        /// </summary>\n        public ");


#line 41 "MethodGroupTemplate.cshtml"
          Write(Model.CodeModel.Name);


#line default
#line hidden
WriteLiteral(" Client { get; private set; }\n");

WriteLiteral("        ");


#line 42 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 43 "MethodGroupTemplate.cshtml"
        

#line default
#line hidden

#line 43 "MethodGroupTemplate.cshtml"
         foreach (MethodCs method in Model.Methods)
        {


#line default
#line hidden
WriteLiteral("        ");


#line 45 "MethodGroupTemplate.cshtml"
      Write(Include(new MethodTemplate(), method));


#line default
#line hidden
WriteLiteral("\n");


#line 46 "MethodGroupTemplate.cshtml"
        

#line default
#line hidden

#line 46 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 46 "MethodGroupTemplate.cshtml"
                  
        }


#line default
#line hidden
WriteLiteral("    }\n}\n");

}
}
}
#pragma warning restore 1591