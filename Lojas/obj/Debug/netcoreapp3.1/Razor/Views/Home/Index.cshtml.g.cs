#pragma checksum "C:\Users\cspcl\Documents\GitHub\pooii-lojasCiA\Lojas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9d74825e1a9202199da94891914e17034572de"
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
#line 1 "C:\Users\cspcl\Documents\GitHub\pooii-lojasCiA\Lojas\Views\_ViewImports.cshtml"
using Lojas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cspcl\Documents\GitHub\pooii-lojasCiA\Lojas\Views\_ViewImports.cshtml"
using Lojas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9d74825e1a9202199da94891914e17034572de", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7408631146e3e970137ee80f78803c58e6e1722", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lojas.Models.Loja>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cspcl\Documents\GitHub\pooii-lojasCiA\Lojas\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p id=""rData""></p>

<div class=""text-center"">
    <h1 class=""display-4"">MENU</h1><br>
    <p>
        <a href=""../Loja/Index"">1- Gerenciar Lojas</a>
    </p>
    <p>
        <a href=""../Produto/Index"">2- Gerenciar Produtos</a>
    </p>
    <p>
        <a href=""../Estoque/Index"">3- Gerenciar Estoques</a>
    </p>
    <p>
        <a href=""../Pedido/Index"">4- Gerenciar Pedidos</a>
    </p>
    <p>
        <a href=""../Entrega/Index"">5- Gerenciar Entregas</a>
    </p>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\cspcl\Documents\GitHub\pooii-lojasCiA\Lojas\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script type=\"text/jscript\">\r\n        var url = \"/Home/DataHoraAtual\";\r\n        $.get(url, null, function (data)\r\n        {\r\n           $(\"#rData\").html(data);\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lojas.Models.Loja>> Html { get; private set; }
    }
}
#pragma warning restore 1591
