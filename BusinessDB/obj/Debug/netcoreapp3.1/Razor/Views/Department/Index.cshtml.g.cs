#pragma checksum "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c38ee36dd5f88f5b6209ac61c091f676590180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\_ViewImports.cshtml"
using BusinessDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\_ViewImports.cshtml"
using BusinessDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c38ee36dd5f88f5b6209ac61c091f676590180", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c4bbc1d8b302cc0be5a59bd96c9f0e8674d3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Department Index</h1>\r\n\r\nThere are ");
#nullable restore
#line 8 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"
     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" departments<br /><br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"
 foreach (Department dep in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 188, "\"", 222, 2);
            WriteAttributeValue("", 195, "/department/details/", 195, 20, true);
#nullable restore
#line 12 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"
WriteAttributeValue("", 215, dep.id, 215, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 12 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"
                                  Write(dep.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/>\r\n");
#nullable restore
#line 13 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Index.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591