#pragma checksum "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "037a130db34a7d0f4897edf4e9274ee6e9da27fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Samochod_Delete), @"mvc.1.0.view", @"/Views/Samochod/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Samochod/Delete.cshtml", typeof(AspNetCore.Views_Samochod_Delete))]
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
#line 1 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\_ViewImports.cshtml"
using ProjektoNeto;

#line default
#line hidden
#line 2 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\_ViewImports.cshtml"
using ProjektoNeto.Models;

#line default
#line hidden
#line 3 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\_ViewImports.cshtml"
using ProjektoNeto.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037a130db34a7d0f4897edf4e9274ee6e9da27fb", @"/Views/Samochod/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e517f99cd3180a38cb2e659b9ce47ddb06716946", @"/Views/_ViewImports.cshtml")]
    public class Views_Samochod_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Samochod>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 121, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"thumbnail\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 138, "\"", 156, 1);
#line 7 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
WriteAttributeValue("", 144, Model.Marka, 144, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 157, "\"", 180, 1);
#line 7 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
WriteAttributeValue("", 163, Model.ZdjecieUrl, 163, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(181, 106, true);
            WriteLiteral(" height=\"500\" width=\"500\" />\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <h3>");
            EndContext();
            BeginContext(288, 11, false);
#line 10 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.Marka);

#line default
#line hidden
            EndContext();
            BeginContext(299, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(303, 11, false);
#line 10 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
                              Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(314, 27, true);
            WriteLiteral("</h3>\r\n                <h4>");
            EndContext();
            BeginContext(342, 10, false);
#line 11 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(352, 27, true);
            WriteLiteral("</h4>\r\n                <h4>");
            EndContext();
            BeginContext(380, 18, false);
#line 12 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(398, 27, true);
            WriteLiteral("</h4>\r\n                <h4>");
            EndContext();
            BeginContext(426, 14, false);
#line 13 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.Przebieg);

#line default
#line hidden
            EndContext();
            BeginContext(440, 27, true);
            WriteLiteral("</h4>\r\n                <h4>");
            EndContext();
            BeginContext(468, 15, false);
#line 14 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.Pojemnosc);

#line default
#line hidden
            EndContext();
            BeginContext(483, 27, true);
            WriteLiteral("</h4>\r\n                <h4>");
            EndContext();
            BeginContext(511, 9, false);
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
               Write(Model.Moc);

#line default
#line hidden
            EndContext();
            BeginContext(520, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(547, 10, false);
#line 16 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
              Write(Model.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(557, 117, true);
            WriteLiteral("</p>\r\n                <h2>Na pewno chcesz usunąć?</h2>\r\n                <h4 class=\"pull-right\">\r\n                    ");
            EndContext();
            BeginContext(674, 355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a9b8051ae984a01a0a055ac4ea4dfd9", async() => {
                BeginContext(700, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(726, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76291d5d8eb6499ea5e427b300f52295", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(762, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(788, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d4bb3cbf5e04175be7cf22939be10e2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 21 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Samochod\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ZdjecieUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(832, 112, true);
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Usuń\" class=\"btn btn-success\" />\r\n                        ");
                EndContext();
                BeginContext(944, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9db6149eccb4900b7603176b1f33214", async() => {
                    BeginContext(990, 6, true);
                    WriteLiteral("Powrót");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1000, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1029, 79, true);
            WriteLiteral("\r\n                </h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Samochod> Html { get; private set; }
    }
}
#pragma warning restore 1591
