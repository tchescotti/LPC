#pragma checksum "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Cliente\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00bd41f7f33b29acdf1ad84e1f93e50e373f4e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Update), @"mvc.1.0.view", @"/Views/Cliente/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Update.cshtml", typeof(AspNetCore.Views_Cliente_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bd41f7f33b29acdf1ad84e1f93e50e373f4e04", @"/Views/Cliente/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2499fcbc8644bf5fde6f44a5378def9501bf5db", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppChamados.Models.Cliente>
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
            WriteLiteral("\n<div class=\"container\">\n\n    <h3>Editar Cliente</h3>\n\n    <br>\n\n    ");
            EndContext();
            BeginContext(103, 1180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e025b3c35697427cb05afeed3b5a8d8f", async() => {
                BeginContext(139, 217, true);
                WriteLiteral("\n\n        <div class=\"col-md-5\">\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-12\">\n                <label for=\"id\">Nome</label>\n                <input class=\"form-control\" type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 356, "\"", 373, 1);
#line 16 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Cliente\Update.cshtml"
WriteAttributeValue("", 364, Model.id, 364, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(374, 234, true);
                WriteLiteral(" readonly>\n            </div>\n        </div> \n\n        <div class=\"row\">\n            <div class=\"form-group col-md-12\">\n                <label for=\"nome\">Nome</label>\n                <input class=\"form-control\" type=\"text\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 608, "\"", 627, 1);
#line 23 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Cliente\Update.cshtml"
WriteAttributeValue("", 616, Model.nome, 616, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(628, 236, true);
                WriteLiteral(">\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-12\">\n                <label for=\"telefone\">Telefone</label>\n                <input class=\"form-control\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 864, "\"", 887, 1);
#line 30 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Cliente\Update.cshtml"
WriteAttributeValue("", 872, Model.telefone, 872, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(888, 228, true);
                WriteLiteral(">\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"form-group col-md-12\">\n                <label for=\"email\">E-mail</label>\n                <input class=\"form-control\" type=\"text\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1116, "\"", 1136, 1);
#line 37 "C:\wamp64\www\4. SEM5_LPC\LAST-G1\AppChamados\Views\Cliente\Update.cshtml"
WriteAttributeValue("", 1124, Model.email, 1124, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1137, 139, true);
                WriteLiteral(">\n            </div>\n        </div>\n\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar Alterações\"/>\n\n        </div>\n\n    ");
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
            BeginContext(1283, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppChamados.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
