#pragma checksum "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4561c40818090d8c42f0b388a575a3c610b15ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Heroes_Index), @"mvc.1.0.view", @"/Views/Heroes/Index.cshtml")]
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
#line 1 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\_ViewImports.cshtml"
using Super_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\_ViewImports.cshtml"
using Super_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4561c40818090d8c42f0b388a575a3c610b15ff1", @"/Views/Heroes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072859464e4b26d53f4b24a01608032d6ec0e62d", @"/Views/_ViewImports.cshtml")]
    public class Views_Heroes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Super_Shop.Models.Hero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
     foreach (var hero in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md p-2\">\r\n        <div class=\"card\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 284, "\"", 317, 1);
#nullable restore
#line 14 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
WriteAttributeValue("", 290, Url.Content(hero.ImageUri), 290, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 318, "\"", 338, 1);
#nullable restore
#line 14 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
WriteAttributeValue("", 324, hero.ImageUri, 324, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
                                  Write(hero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
                                Write(hero.PowerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\" target=\"_blank\" class=\"btn btn-primary\">Learn more</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\joris\OneDrive - Avans Hogeschool\Visual Studio repos\PRG5-Super-Shop\Super-Shop\Super-Shop\Views\Heroes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Super_Shop.Models.Hero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
