#pragma checksum "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e29ea2e98df18a49d5c6d50ba04d1076525adb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
#nullable restore
#line 8 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\_ViewImports.cshtml"
using CareerSite.MvcWebUI.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e29ea2e98df18a49d5c6d50ba04d1076525adb7", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad298ce53a9a8b6eeee339ed1b682b6b778e54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"
  
    string url = "";
    if (Context.Request.Path.ToString().Length >= 4)
    {
        url = Context.Request.Path.ToString().Remove(4);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"list-group\">\r\n");
#nullable restore
#line 10 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"
     if (url == "/tr/" || url == "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 12 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"
                                                              Write(Model.NameTr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 13 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 16 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"
                                                              Write(Model.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 17 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Shared\_categories.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
