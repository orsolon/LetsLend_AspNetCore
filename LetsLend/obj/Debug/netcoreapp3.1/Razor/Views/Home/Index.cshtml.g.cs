#pragma checksum "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa1c1dff7eddafcbb940360785971ba097d4340c"
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
#line 1 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\_ViewImports.cshtml"
using LetsLend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\_ViewImports.cshtml"
using LetsLend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa1c1dff7eddafcbb940360785971ba097d4340c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac84860dfa6e412389b8590c18d349caf2b070bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LetsLend.ViewModels.ItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Lets Lend";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""text-center"">    
    <h1 class=""display-4 mb-3"">Let´s Lend</h1>
</div>
    <div class=""d-flex justify-content-start m-5"">
        <h5>Meus Itens <b class=""text-success"">Disponíveis</b> para emprétimo:</h5>
    </div>
        
  
    <div class=""container"">
");
#nullable restore
#line 16 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\Home\Index.cshtml"
         foreach (var item in Model.Items)
        {
            if (item.IsAvaiable == true && item.ItemBorrower == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card shadow-sm mb-2 bg-body rounded\">\r\n                    <div class=\"card-body\"><h5>");
#nullable restore
#line 21 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\Home\Index.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\denni\Desktop\Programação\Let's Code\8. ASP.NET MVC CORE\Projeto\LetsLend_AspNetCore\LetsLend\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LetsLend.ViewModels.ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
