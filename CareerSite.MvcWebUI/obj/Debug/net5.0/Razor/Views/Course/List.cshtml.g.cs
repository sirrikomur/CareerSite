#pragma checksum "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c10206a9d4cef88ad45d423d0213b90eb61ff6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_List), @"mvc.1.0.view", @"/Views/Course/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c10206a9d4cef88ad45d423d0213b90eb61ff6e", @"/Views/Course/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad298ce53a9a8b6eeee339ed1b682b6b778e54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
  
    var popularClass = Model.Courses.Count>2? "popular":"";
    var courses = Model.Courses;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 14 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
 if(courses.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
Write(await Html.PartialAsync("_nocourse"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
                                         
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">                  \r\n");
#nullable restore
#line 21 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
         foreach (var course in courses)
        {    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 24 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
           Write(await Html.PartialAsync("_course", course));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n        </div>       \r\n");
#nullable restore
#line 26 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "A:\CareerSite\CareerSite\CareerSite.MvcWebUI\Views\Course\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
