#pragma checksum "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7450f7d9b2b00067a4eae7f8348d7ed53e1878a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Editar), @"mvc.1.0.view", @"/Views/Professor/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7450f7d9b2b00067a4eae7f8348d7ed53e1878a", @"/Views/Professor/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b3e333c18c8ea7e8d4c59c5e1b3520a131591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
  
    var professor = ViewBag.profRetornado;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Página de cadastro de Professor</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7450f7d9b2b00067a4eae7f8348d7ed53e1878a4125", async() => {
                WriteLiteral("\n    <div class=\"form_aluno_id\">\n        <label for=\"id\">Id:</label>\n        <input type=\"text\" name=\"idProf\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 292, "\"", 313, 1);
#nullable restore
#line 10 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 300, professor.Id, 300, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    </div>\n    <div>\n        <label for=\"nome\">Nome:</label>\n        <input type=\"text\" name=\"nomeProf\" placeholder=\"Ex. Lucas Medina\" id=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 485, 1);
#nullable restore
#line 14 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 470, professor.Nome, 470, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n    </div>\n    <div>\n        <label for=\"email\">Email:</label>\n        <input type=\"text\" name=\"emailProf\" placeholder=\"Ex. medina@gmail.com\" id=\"email\"");
                BeginWriteAttribute("value", " value=\"", 663, "\"", 687, 1);
#nullable restore
#line 18 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 671, professor.Email, 671, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n    </div>\n    <div>\n        <label for=\"end\">Endereço:</label>\n        <input type=\"text\" name=\"enderecoProf\" placeholder=\"Ex. Rua Mogi\" id=\"end\"");
                BeginWriteAttribute("value", " value=\"", 859, "\"", 886, 1);
#nullable restore
#line 22 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 867, professor.Endereco, 867, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n    </div>\n    <div>\n        <label for=\"tel\">Telefone:</label>\n        <input type=\"text\" name=\"telefoneProf\" placeholder=\"Ex. 11 91111-3333\" id=\"tel\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1090, 1);
#nullable restore
#line 26 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 1071, professor.Telefone, 1071, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n    </div>\n    <div>\n        <label for=\"esc\">Cargo:</label>\n        <input type=\"text\" name=\"cargoProf\" placeholder=\"Ex. 2° ano\" id=\"cargo\"");
                BeginWriteAttribute("value", " value=\"", 1256, "\"", 1280, 1);
#nullable restore
#line 30 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
WriteAttributeValue("", 1264, professor.Cargo, 1264, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n    </div>\n    <button type=\"submit\">Atualizar</button>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 7 "C:\Users\dev\Desktop\ProjetoFinal\MVCRazorCRUD\Views\Professor\Editar.cshtml"
AddHtmlAttributeValue("", 105, Url.Action("Atualizar"), 105, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
