#pragma checksum "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6904163e90ca5bf89ffe132e6c6f249d45d3968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_GetCountryById), @"mvc.1.0.view", @"/Views/Countries/GetCountryById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Countries/GetCountryById.cshtml", typeof(AspNetCore.Views_Countries_GetCountryById))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6904163e90ca5bf89ffe132e6c6f249d45d3968", @"/Views/Countries/GetCountryById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516f0bfd83777c6654e705326b7d263116ab4bf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_GetCountryById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookApiProject.Dtos.CategoryDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml"
  
    ViewData["Title"] = "GetCountryById";

#line default
#line hidden
            BeginContext(86, 72, true);
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\n\n<h4>");
            EndContext();
            BeginContext(159, 15, false);
#line 7 "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(174, 115, true);
            WriteLiteral("</h4>\n<div>\n    <h1>Country Details</h1>\n    <br/>\n    <div>\n        <p>\n            <strong>Country Name:</strong>");
            EndContext();
            BeginContext(290, 10, false);
#line 13 "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(300, 159, true);
            WriteLiteral(" \n        </p>\n        <div class=\"form-group text-center\">\n            <a class=\"btn btn-sm btn-primary\" asp-controller=\"Countries\" asp-action=\"UpdateCountry\"");
            EndContext();
            BeginWriteAttribute("asp-route-countryId", "\n               asp-route-countryId=\"", 459, "\"", 505, 1);
#line 17 "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml"
WriteAttributeValue("", 496, Model.Id, 496, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(506, 120, true);
            WriteLiteral(">| Update Country</a>\n            <a class=\"btn btn-sm btn-danger\" asp-controller=\"Countries\" asp-action=\"DeleteCountry\"");
            EndContext();
            BeginWriteAttribute("asp-route-countryId", "\n               asp-route-countryId=\"", 626, "\"", 672, 1);
#line 19 "C:\Users\mdjak\Downloads\BookAPI-start-master\BookAPI-start-master\BookGUI\Views\Countries\GetCountryById.cshtml"
WriteAttributeValue("", 663, Model.Id, 663, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(673, 83, true);
            WriteLiteral("> | Delete Country</a>\n        </div>\n    </div>\n</div>\n\n\n<h1>GetCountryById</h1>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookApiProject.Dtos.CategoryDto> Html { get; private set; }
    }
}
#pragma warning restore 1591