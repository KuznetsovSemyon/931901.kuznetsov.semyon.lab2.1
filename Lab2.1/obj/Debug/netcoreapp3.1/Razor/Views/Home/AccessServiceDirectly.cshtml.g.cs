#pragma checksum "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f4313a4a26dc8f935e4186152b6dee31e06a7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AccessServiceDirectly), @"mvc.1.0.view", @"/Views/Home/AccessServiceDirectly.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
using Lab2._1.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f4313a4a26dc8f935e4186152b6dee31e06a7d", @"/Views/Home/AccessServiceDirectly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3fd2995108bed1fc943fcb6379967117591877", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AccessServiceDirectly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
  
    ViewData["Title"] = "AccessServiceDirectly";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <h1>AccessServiceDirectly</h1>\n    <h3>Rand Value First : ");
#nullable restore
#line 9 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
                      Write(calc.a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Rand Value Second : ");
#nullable restore
#line 10 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
                       Write(calc.b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Add :</h3>\n    <p>");
#nullable restore
#line 12 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
  Write(calc.Plus());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Sub :</h3>\n    <p>");
#nullable restore
#line 14 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
  Write(calc.Minus());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Mult :</h3>\n    <p>");
#nullable restore
#line 16 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
  Write(calc.Multiplication());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <h3>Div :</h3>\n    <p>");
#nullable restore
#line 18 "C:\Users\lenovo\Downloads\931901.kolpakova.alexandra.lab2._1-main\Lab2.1\Lab2.1\Views\Home\AccessServiceDirectly.cshtml"
  Write(calc.Division());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Calc calc { get; private set; } = default!;
        #nullable disable
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