#pragma checksum "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b88f3ee605f45f5acaaf8d8d4c9345fbedf7c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b88f3ee605f45f5acaaf8d8d4c9345fbedf7c1b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e517f99cd3180a38cb2e659b9ce47ddb06716946", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Szczegoly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::ProjektoNeto.TagHelpers.SecondTagHelper __ProjektoNeto_TagHelpers_SecondTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(22, 11, false);
#line 3 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
Write(Model.Tytul);

#line default
#line hidden
            EndContext();
            BeginContext(33, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
 foreach (var samochod in Model.Samochody)
{

#line default
#line hidden
            BeginContext(91, 91, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            ");
            EndContext();
            BeginContext(182, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25b12a9ebce48dc85294bc3420105e1", async() => {
                BeginContext(258, 22, true);
                WriteLiteral("\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 280, "\"", 309, 1);
#line 11 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
WriteAttributeValue("", 286, samochod.MiniaturkaUrl, 286, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(310, 22, true);
                WriteLiteral(" alt=\"\">\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                              WriteLiteral(samochod.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(336, 76, true);
            WriteLiteral("\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(413, 27, false);
#line 14 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                  Write(samochod.Cena.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(440, 23, true);
            WriteLiteral("</h3>\r\n                ");
            EndContext();
            BeginContext(463, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("second-tag-helper", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "565cc8ccdc14482c83c1565105fd04f7", async() => {
            }
            );
            __ProjektoNeto_TagHelpers_SecondTagHelper = CreateTagHelper<global::ProjektoNeto.TagHelpers.SecondTagHelper>();
            __tagHelperExecutionContext.Add(__ProjektoNeto_TagHelpers_SecondTagHelper);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                              WriteLiteral(samochod.Marka);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Marka = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("marka", __ProjektoNeto_TagHelpers_SecondTagHelper.Marka, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                      WriteLiteral(samochod.Model);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Model = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __ProjektoNeto_TagHelpers_SecondTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
__ProjektoNeto_TagHelpers_SecondTagHelper.RokProdukcji = samochod.RokProdukcji;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("rok-produkcji", __ProjektoNeto_TagHelpers_SecondTagHelper.RokProdukcji, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                                                                                        WriteLiteral(samochod.Przebieg);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Przebieg = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("przebieg", __ProjektoNeto_TagHelpers_SecondTagHelper.Przebieg, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                                                                                                                       WriteLiteral(samochod.Pojemnosc);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Pojemnosc = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("pojemnosc", __ProjektoNeto_TagHelpers_SecondTagHelper.Pojemnosc, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                                                                                                                                                 WriteLiteral(samochod.Moc);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Moc = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("moc", __ProjektoNeto_TagHelpers_SecondTagHelper.Moc, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
                                                                                                                                                                                                      WriteLiteral(samochod.Opis);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ProjektoNeto_TagHelpers_SecondTagHelper.Opis = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("opis", __ProjektoNeto_TagHelpers_SecondTagHelper.Opis, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(693, 68, true);
            WriteLiteral("\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Jasiu\source\repos\ProjektoNeto\ProjektoNeto\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
