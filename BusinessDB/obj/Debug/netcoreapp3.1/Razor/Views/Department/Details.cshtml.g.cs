#pragma checksum "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e69fe7f0aa138685cc85663d245dfeb50448c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Details), @"mvc.1.0.view", @"/Views/Department/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e69fe7f0aa138685cc85663d245dfeb50448c52", @"/Views/Department/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c4bbc1d8b302cc0be5a59bd96c9f0e8674d3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Details.cshtml"
Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n");
#nullable restore
#line 9 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Details.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n");
#nullable restore
#line 10 "C:\Users\mking10\dev\Week 11\BusinessDB\Views\Department\Details.cshtml"
Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
