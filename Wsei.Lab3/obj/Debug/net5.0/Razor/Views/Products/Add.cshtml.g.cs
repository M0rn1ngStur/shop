#pragma checksum "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a6c535efd91a95b1d996edf08cd0bbf96c75ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Add), @"mvc.1.0.view", @"/Views/Products/Add.cshtml")]
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
#line 1 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\_ViewImports.cshtml"
using Wsei.Lab3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\_ViewImports.cshtml"
using Wsei.Lab3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a6c535efd91a95b1d996edf08cd0bbf96c75ce", @"/Views/Products/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94bfb06836c622f185995c3fafe161011084ab85", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductStatsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Product added successfully</h1>\r\n\r\n<div>Name length: ");
#nullable restore
#line 5 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\Add.cshtml"
             Write(Model.NameLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Description length: ");
#nullable restore
#line 6 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\Add.cshtml"
                    Write(Model.DescriptionLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductStatsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
