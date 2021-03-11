#pragma checksum "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47498249be036612b8366712a3403f835d920327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bookstore5.Pages.Pages_Buy), @"mvc.1.0.razor-page", @"/Pages/Buy.cshtml")]
namespace Bookstore5.Pages
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
#line 2 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\_ViewImports.cshtml"
using Bookstore5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\_ViewImports.cshtml"
using Bookstore5.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47498249be036612b8366712a3403f835d920327", @"/Pages/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb180e6143adb566d5d8827c6d90b825d536b9b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
  
    // this is an MVVM (Model, View, ViewModel) method of building web pages UNLIKE MVC (Model, View, Controller). RazorPages are self-contained and do routing internally. This is still not the most common method, but probably will be in the future.

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Your Cart</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Project</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Subtotal</th>
        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
         foreach (var line in Model.Cart.Lines) //pull cart lines
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
               Write(line.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
               Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 25 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
                Write(line.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 26 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
                 Write(line.Quantity * line.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-black-50 text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47498249be036612b8366712a3403f835d9203276026", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"BookId\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 1034, "\"", 1091, 1);
#nullable restore
#line 30 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
WriteAttributeValue("", 1074, line.Book.BookId, 1074, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 1158, "\"", 1214, 1);
#nullable restore
#line 32 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
WriteAttributeValue("", 1198, Model.ReturnUrl, 1198, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
           Write(Model.Cart.ComputeTotalSum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!--Calculates the total sum and uses the ToString function to make it currency-->\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1724, "\"", 1747, 1);
#nullable restore
#line 48 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Pages\Buy.cshtml"
WriteAttributeValue("", 1731, Model.ReturnUrl, 1731, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore5.Pages.BuyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore5.Pages.BuyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore5.Pages.BuyModel>)PageContext?.ViewData;
        public Bookstore5.Pages.BuyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
