#pragma checksum "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9662efbb3696fc5e5c05b8fedb670ad064310e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 2 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using CareerSite.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using CareerSite.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using CareerSite.MvcWebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using CareerSite.MvcWebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9662efbb3696fc5e5c05b8fedb670ad064310e0c", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4ffcd7bc7b9081e83a945ec8bd0a9f7f114214", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 3 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Index.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\nproduct index");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
