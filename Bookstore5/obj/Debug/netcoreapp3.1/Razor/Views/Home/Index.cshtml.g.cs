#pragma checksum "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a0101cbea92168bed4d900bfcee2a6f386c527"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a0101cbea92168bed4d900bfcee2a6f386c527", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e702b14e2f04b94ac4ee9dbf0add12c00ca4566", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-center display-2\">Welcome to the Bookstore!</h1>\r\n</header>\r\n<br /><br /><br /><br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 15 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
                     Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"lead\">By ");
#nullable restore
#line 16 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
                  Write(x.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
                               Write(x.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Publisher: ");
#nullable restore
#line 17 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
             Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>ISBN: ");
#nullable restore
#line 18 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
        Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Classification: ");
#nullable restore
#line 19 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
                  Write(x.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Category: ");
#nullable restore
#line 20 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
            Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Price: ");
#nullable restore
#line 21 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
         Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
#nullable restore
#line 23 "C:\Users\lukyb\source\repos\Bookstore5\Bookstore5\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
