#pragma checksum "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "417d409221c09840d3c2c580a14523d9aedf154d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_description), @"mvc.1.0.view", @"/Views/Products/description.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"417d409221c09840d3c2c580a14523d9aedf154d", @"/Views/Products/description.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94bfb06836c622f185995c3fafe161011084ab85", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Wsei.Lab3.Entities.ProductEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<tbody>\r\n");
#nullable restore
#line 5 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
                  ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 12 "C:\Users\user\Desktop\SHOP - WSEI\shop\Wsei.Lab3\Views\Products\description.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Wsei.Lab3.Entities.ProductEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
