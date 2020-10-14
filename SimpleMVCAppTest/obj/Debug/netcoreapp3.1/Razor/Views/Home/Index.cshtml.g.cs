#pragma checksum "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66b11a739352152ec5cf8905ba7d66572999112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\_ViewImports.cshtml"
using SimpleMVCAppTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\_ViewImports.cshtml"
using SimpleMVCAppTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66b11a739352152ec5cf8905ba7d66572999112", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3c0e48d99cff4a7b54097623802e2692e0967d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleMVCAppTest.ViewModel.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Choose the country</p>\r\n        ");
#nullable restore
#line 10 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
   Write(Html.DropDownListFor(model => model.countries,
                            new SelectList(Model.countries, "IsoCode", "Name"),
                            "Select country",
                            new { @class = "form-control", @id = "ddlCountry" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <p>Choose animal</p>\r\n        ");
#nullable restore
#line 16 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
   Write(Html.DropDownListFor(model => model.animals,
                            new SelectList(String.Empty, "ScientificName", "ScientificName"),
                            "Select animal",
                            new { @class = "form-control", @id = "ddlAnimal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    \r\n    $(document).ready(function () {\r\n        $(\"#ddlCountry\").change(function () {\r\n            $(\"#ddlAnimal\").empty();\r\n            $.ajax({\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 30 "C:\Users\gobm\source\repos\BairesDevCodingTest.2\SimpleMVCAppTest\SimpleMVCAppTest\Views\Home\Index.cshtml"
                 Write(Url.Action("GetAnimalByCountry"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                dataType: 'json',
                data: { country: $(""#ddlCountry"").val() },
                success: function (animals) {
                    $.each(animals, function (i, animal) {
                        console.log(animal);
                        $(""#ddlAnimal"").append('<option>' + animal.scientificName + '</option>');
                    });
                },
                error: function (ex) {
                    alert('Failed to retrieve animals.' + ex);
                }
            });
            return false;
        })
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleMVCAppTest.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591