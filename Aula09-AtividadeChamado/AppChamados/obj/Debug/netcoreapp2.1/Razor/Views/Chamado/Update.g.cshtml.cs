#pragma checksum "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1125526e0940437250c609a55fe5276e90b1ddd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chamado_Update), @"mvc.1.0.view", @"/Views/Chamado/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chamado/Update.cshtml", typeof(AspNetCore.Views_Chamado_Update))]
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
#line 1 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\_ViewImports.cshtml"
using AppChamados;

#line default
#line hidden
#line 2 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\_ViewImports.cshtml"
using AppChamados.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1125526e0940437250c609a55fe5276e90b1ddd2", @"/Views/Chamado/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2499fcbc8644bf5fde6f44a5378def9501bf5db", @"/Views/_ViewImports.cshtml")]
    public class Views_Chamado_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppChamados.Models.Chamado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(34, 69, true);
            WriteLiteral("\n<div class=\"container\">\n\n    <h3>Editar Chamado</h3>\n\n    <br>\n\n    ");
            EndContext();
            BeginContext(103, 2406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6395bf56ee3747ebbefafa23ccaeb35c", async() => {
                BeginContext(139, 236, true);
                WriteLiteral("\n\n        <div class=\"col-md-5\">\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-12\">\n                <label for=\"cliente.id\">Cliente</label>\n                <input class=\"form-control\" type=\"text\" name=\"cliente.id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 375, "\"", 402, 1);
#line 16 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 383, Model.cliente.nome, 383, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(403, 70, true);
                WriteLiteral(" readonly>\n                <input hidden type=\"text\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 473, "\"", 490, 1);
#line 17 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 481, Model.id, 481, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(491, 265, true);
                WriteLiteral(@"/>
            </div>                
        </div>

        <div class=""row"">
            <div class=""form-group col-md-12"">
                <label for=""descricao"">Descrição do Problema</label>
                <input class=""form-control"" rows=""5"" name=""descricao""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 756, "\"", 780, 1);
#line 24 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 764, Model.descricao, 764, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(781, 237, true);
                WriteLiteral(">\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-6\">\n                <label for=\"dataChamado\">Data</label>\n                <input class=\"form-control\" type=\"text\" name=\"dataChamado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1018, "\"", 1067, 1);
#line 31 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1026, Model.dataChamado.ToString("dd/MM/yyyy"), 1026, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1068, 210, true);
                WriteLiteral(" readonly>\n            </div>\n\n            <div class=\"form-group col-md-6\">\n                <label for=\"horaInicio\">Hora Início</label>\n                <input class=\"form-control\" type=\"time\" name=\"horaInicio\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1278, "\"", 1303, 1);
#line 36 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1286, Model.horaInicio, 1286, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1304, 254, true);
                WriteLiteral(" readonly>\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-6\">\n                <label for=\"dataSolucao\">Data Solução</label>\n                <input class=\"form-control\" type=\"date\" name=\"dataSolucao\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1558, "\"", 1584, 1);
#line 43 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1566, Model.dataSolucao, 1566, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1585, 192, true);
                WriteLiteral(">\n            </div>\n\n            <div class=\"form-group col-md-6\">\n                <label for=\"horaFim\">Hora Fim</label>\n                <input class=\"form-control\" type=\"time\" name=\"horaFim\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1777, "\"", 1799, 1);
#line 48 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1785, Model.horaFim, 1785, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1800, 232, true);
                WriteLiteral(">\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-6\">\n                <label for=\"situacao.id\">Situação</label>\n                <select class=\"form-control\" name=\"situacao.id\">\n");
                EndContext();
#line 56 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
                     foreach(var situacao in @ViewBag.situacoes)
                    {

#line default
#line hidden
                BeginContext(2119, 25, true);
                WriteLiteral("                        <");
                EndContext();
                BeginContext(2145, 6, true);
                WriteLiteral("option");
                EndContext();
                BeginWriteAttribute("value", " value=", 2151, "", 2170, 1);
#line 58 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 2158, situacao.id, 2158, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 2170, "\"", 2217, 1);
#line 58 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 2181, situacao.id == @Model.situacao.id, 2181, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2218, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2220, 18, false);
#line 58 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
                                                                                               Write(situacao.descricao);

#line default
#line hidden
                EndContext();
                BeginContext(2238, 2, true);
                WriteLiteral("</");
                EndContext();
                BeginContext(2241, 8, true);
                WriteLiteral("option>\n");
                EndContext();
#line 59 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Chamado\Update.cshtml"
                    }

#line default
#line hidden
                BeginContext(2271, 231, true);
                WriteLiteral("                </select>\n            </div>\n        </div>\n\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar Alterações\"/>\n        \n        <a href=\"Index\" class=\"btn btn-primary\">Voltar</a>\n\n        </div>\n\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2509, 8, true);
            WriteLiteral("\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppChamados.Models.Chamado> Html { get; private set; }
    }
}
#pragma warning restore 1591
