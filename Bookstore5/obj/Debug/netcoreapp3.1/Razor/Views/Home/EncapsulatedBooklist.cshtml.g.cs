#pragma checksum "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7cb4f0d65010567dbd8eb30baa957893231e341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EncapsulatedBooklist), @"mvc.1.0.view", @"/Views/Home/EncapsulatedBooklist.cshtml")]
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
#line 1 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\_ViewImports.cshtml"
using Bookstore5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\_ViewImports.cshtml"
using Bookstore5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\_ViewImports.cshtml"
using Bookstore5.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\_ViewImports.cshtml"
using Bookstore5.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7cb4f0d65010567dbd8eb30baa957893231e341", @"/Views/Home/EncapsulatedBooklist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97adc67dbe7b1508c98a6d53ff1d9037bcf0727f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EncapsulatedBooklist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--This page is the partial view for index that shows all the book cards-->

<!--the idea is a list of titles/authors that, when clicked, expand to show more information-->
<div class=""card"">
    <div class=""card-header"">
        <h5 class=""mb-0"">
            <a class=""btn"" data-toggle=""collapse""");
            BeginWriteAttribute("href", " href=\"", 318, "\"", 341, 2);
            WriteAttributeValue("", 325, "#", 325, 1, true);
#nullable restore
#line 8 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
WriteAttributeValue("", 326, Model.LastName, 326, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-expanded=""true"" aria-controls=""collapseOne"" style=""box-shadow: none;"">
                <!--you do not know how much time I spent trying to hunt down the box-shadow in the bootstrap.css.min file. It doesn't matter what you change. The box-shadow is forever.-->
                <h1 class=""display-4 row"">");
#nullable restore
#line 10 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"lead row\">By ");
#nullable restore
#line 11 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </a>\r\n        </h5>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 801, "\"", 821, 1);
#nullable restore
#line 15 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
WriteAttributeValue("", 806, Model.LastName, 806, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 839, "", 869, 1);
#nullable restore
#line 15 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
WriteAttributeValue("", 856, Model.BookId, 856, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-parent=""#accordion"">
        <!--This is a terrible solution to make cards with unique ids. ""but what if the authors have the same last name?"" you may ask, to which i reply ""I didn't want to make another data entry into my model, so suck it""-->
        <div class=""card-body pl-5"">
            <p class=""row"">Publisher: ");
#nullable restore
#line 18 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                 Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"row\">ISBN: ");
#nullable restore
#line 19 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                            Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"row\">Classification: ");
#nullable restore
#line 20 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                      Write(Model.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"row\">Category: ");
#nullable restore
#line 21 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                                Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"row\">Price: $");
#nullable restore
#line 22 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"row\">Pages: ");
#nullable restore
#line 23 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
                             Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7cb4f0d65010567dbd8eb30baa957893231e3419553", async() => {
                WriteLiteral(" <!--this makes the buying button-->\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7cb4f0d65010567dbd8eb30baa957893231e3419859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 26 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1720, "\"", 1775, 1);
#nullable restore
#line 27 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
WriteAttributeValue("", 1728, ViewContext.HttpContext.Request.PathAndQuery(), 1728, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <span class=\"card-text p-1\">\r\n                  ");
#nullable restore
#line 29 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
             Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                  <button type=\"submit\" class=\"btn-success btn-sm pull-right\" style=\"float:right\">\r\n                      Buy Now!\r\n                  </button>\r\n            </span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\EncapsulatedBooklist.cshtml"
AddHtmlAttributeValue("", 1528, Model.BookId, 1528, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
