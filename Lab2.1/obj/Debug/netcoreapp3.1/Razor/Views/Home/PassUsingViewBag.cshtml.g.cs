#pragma checksum "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db2cc76bdb18b4e81863e66e050b1f1e1483d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PassUsingViewBag), @"mvc.1.0.view", @"/Views/Home/PassUsingViewBag.cshtml")]
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
#line 1 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\_ViewImports.cshtml"
using Lab2._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\_ViewImports.cshtml"
using Lab2._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db2cc76bdb18b4e81863e66e050b1f1e1483d52", @"/Views/Home/PassUsingViewBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3fd2995108bed1fc943fcb6379967117591877", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PassUsingViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
   
    ViewData["Title"] = "PassUsingViewBag"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\n    <h1>PassUsingViewBag</h1>\n    <h3>Rand Value First : ");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
                      Write(ViewBag.Nums.a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Rand Value Second : ");
#nullable restore
#line 7 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
                       Write(ViewBag.Nums.b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Add :</h3>\n    <p>");
#nullable restore
#line 9 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
  Write(ViewBag.Nums.Add());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Sub :</h3>\n    <p>");
#nullable restore
#line 11 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
  Write(ViewBag.Nums.Sub());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Mult :</h3>\n    <p>");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
  Write(ViewBag.Nums.Mul());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Div :</h3>\n    <p>");
#nullable restore
#line 15 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\PassUsingViewBag.cshtml"
  Write(ViewBag.Nums.Div());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
