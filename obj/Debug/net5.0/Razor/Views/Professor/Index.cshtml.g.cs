#pragma checksum "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e1a969e645483760374b7d354782237cb4f070c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
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
#line 1 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e1a969e645483760374b7d354782237cb4f070c", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b3e333c18c8ea7e8d4c59c5e1b3520a131591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
  
    var listaDeProf = ViewBag.ListaDeProfessores;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Listagem de Professores</h1>\n\n<table class=\"table table-success table-striped\">\n    <thead>\n    <th>Id</th>\n    <th>Nome</th>\n    <th>Email</th>\n    <th>Endereço</th>\n    <th>Telefone</th>\n    <th>Cargo</th>\n    <th>Ação</th>\n    </thead>\n");
#nullable restore
#line 17 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
     foreach (var item in listaDeProf)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 20 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 592, "\"", 648, 2);
            WriteAttributeValue("", 599, "https://localhost:44375/Professor/Editar/", 599, 41, true);
#nullable restore
#line 27 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
WriteAttributeValue("", 640, item.Id, 640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 749, 2);
            WriteAttributeValue("", 707, "https://localhost:44375/Professor/", 707, 34, true);
#nullable restore
#line 28 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
WriteAttributeValue("", 741, item.Id, 741, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 31 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n");
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