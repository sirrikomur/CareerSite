#pragma checksum "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d85ae32bc795454d01d553b674043ab72b6686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d85ae32bc795454d01d553b674043ab72b6686", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad298ce53a9a8b6eeee339ed1b682b6b778e54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
  
    string url = "";
    if (Context.Request.Path.ToString().Length >= 4)
    {
        url = Context.Request.Path.ToString().Remove(4);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76d85ae32bc795454d01d553b674043ab72b66865681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 439, "~/img/", 439, 6, true);
#nullable restore
#line 21 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
AddHtmlAttributeValue("", 445, Model.ImageUrl, 445, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n");
#nullable restore
#line 24 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                 if (url == "/tr/" || url == "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"card-title\">");
#nullable restore
#line 26 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                      Write(Model.NameTr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 27 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                    Write(Model.DescriptionTr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"card-title\">");
#nullable restore
#line 31 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                      Write(Model.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 32 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                    Write(Model.DescriptionEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"card-text\">\r\n                    <small class=\"text-muted\">");
#nullable restore
#line 35 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                         Write(Localizer["LastEdited"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 35 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\Details.cshtml"
                                                                   Write(Model.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
