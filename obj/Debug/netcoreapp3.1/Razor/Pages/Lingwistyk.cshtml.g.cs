#pragma checksum "/Users/krystian/Projects/SPTP/SPTP/Pages/Lingwistyk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cda3807904a8fafc79e5e39a6d63bc4eace41fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SPTP.Pages.Pages_Lingwistyk), @"mvc.1.0.razor-page", @"/Pages/Lingwistyk.cshtml")]
namespace SPTP.Pages
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
#line 1 "/Users/krystian/Projects/SPTP/SPTP/Pages/_ViewImports.cshtml"
using SPTP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cda3807904a8fafc79e5e39a6d63bc4eace41fb", @"/Pages/Lingwistyk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7058a0225ae22c82f3e8f32c3d4c537955fdc3d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Lingwistyk : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/krystian/Projects/SPTP/SPTP/Pages/Lingwistyk.cshtml"
  
    ViewData["Title"] = "Interfejs lingwistyka";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/Users/krystian/Projects/SPTP/SPTP/Pages/Lingwistyk.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div class=\"modele\">\n    <a");
            BeginWriteAttribute("href", " href=\"", 136, "\"", 143, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"marked\">Model 1</a>\n    <a");
            BeginWriteAttribute("href", " href=\"", 178, "\"", 185, 0);
            EndWriteAttribute();
            WriteLiteral(">Model 2</a>\n    <a");
            BeginWriteAttribute("href", " href=\"", 205, "\"", 212, 0);
            EndWriteAttribute();
            WriteLiteral(">Model 3</a>\n</div>\n<div class=\"modele\">\n    <a");
            BeginWriteAttribute("href", " href=\"", 260, "\"", 267, 0);
            EndWriteAttribute();
            WriteLiteral(">Kryterium 1</a>\n    <a");
            BeginWriteAttribute("href", " href=\"", 291, "\"", 298, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"marked\">Kryterium 2</a>\n    <a");
            BeginWriteAttribute("href", " href=\"", 337, "\"", 344, 0);
            EndWriteAttribute();
            WriteLiteral(">Kryterium 3</a>\n</div>\n<div class=\"szczegoly\">\n    <p>Nazwa kryterium</p>\n    <input type=\"text\" value=\"Kryterium 2\"/><br />\n    <p>Opis</p>\n    <textarea cols=\"40\" rows=\"10\"></textarea><br />\n    <input type=\"submit\" value=\"Zapisz\"/>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591