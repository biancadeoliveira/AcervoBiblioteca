#pragma checksum "C:\Users\bibis\source\repos\Biblioteca\Biblioteca\Views\Livros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b604ffe66868702eb8e2609f6afd0dc0071be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livros_Index), @"mvc.1.0.view", @"/Views/Livros/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livros/Index.cshtml", typeof(AspNetCore.Views_Livros_Index))]
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
#line 1 "C:\Users\bibis\source\repos\Biblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#line 2 "C:\Users\bibis\source\repos\Biblioteca\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b604ffe66868702eb8e2609f6afd0dc0071be8", @"/Views/Livros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c632aee1c6109a664772be6f7ee76d46bec2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Livros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bibis\source\repos\Biblioteca\Biblioteca\Views\Livros\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\bibis\source\repos\Biblioteca\Biblioteca\Views\Livros\Index.cshtml"
  
    ViewData["Title"] = "Acervo";

#line default
#line hidden
            BeginContext(76, 1086, true);
            WriteLiteral(@"
<h3 class=""font-weight-normal"">Todos os livros</h3>
<hr />
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-bordered table-responsive-sm"">
            <thead>
                <tr>
                    <td>Obra</td>
                    <td>Autor</td>
                    <td>Ano Lançamento</td>
                    <td>Gênero</td>
                    <td>&nbsp;</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td class=""text-center"">
                        <div class=""btn-group"">
                            <button class=""btn btn-info"">Ver</button>
                            <button class=""btn btn-success"">Editar</button>
                            <button class=""btn btn-danger"">Excluir</button>
                        </div>
                    </td>
                </tr>
");
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
