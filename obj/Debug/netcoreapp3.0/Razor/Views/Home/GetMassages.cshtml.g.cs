#pragma checksum "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e766ceb24991da9e2773a0a11d1f8d6e0be61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetMassages), @"mvc.1.0.view", @"/Views/Home/GetMassages.cshtml")]
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
#line 1 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\_ViewImports.cshtml"
using TestApplicationForVR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\_ViewImports.cshtml"
using TestApplicationForVR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e766ceb24991da9e2773a0a11d1f8d6e0be61a", @"/Views/Home/GetMassages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f46eaf82f17848cf3a191ef0596d1d69f8a709", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetMassages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Massage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
  
    ViewData["Title"] = "GetMassages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>User Id</th>\r\n            <th>Time of Creation</th>\r\n            <th>Massage</th>\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
               Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
               Write(item.TimeOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<td>\r\n    ");
#nullable restore
#line 38 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
Write(Html.ActionLink("Sort by date", "GetMassagesSortedByDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Users\Ugleb\source\repos\TestApplicationForVR\TestApplicationForVR\Views\Home\GetMassages.cshtml"
Write(Html.ActionLink("Sort by Id", "GetMassagesSortedById"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Massage>> Html { get; private set; }
    }
}
#pragma warning restore 1591