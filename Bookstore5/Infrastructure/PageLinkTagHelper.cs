using Bookstore5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper //the point of tagHelpers is to build HTML dynamically
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            //the following is to put in the bootstrap styling for pagination

            TagBuilder result = new TagBuilder("nav");
            result.Attributes["aria-label"] = "Page navigation";

            TagBuilder pagination = new TagBuilder("ul");
            pagination.Attributes["class"] = "pagination justify-content-center";

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder listit = new TagBuilder("li");
                listit.Attributes["class"] = "page-item";
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["class"] = "page-link";
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());

                listit.InnerHtml.AppendHtml(tag);
                pagination.InnerHtml.AppendHtml(listit);
            }

            result.InnerHtml.AppendHtml(pagination);

            output.Content.AppendHtml(result);

            // in the end, our html is:
            // <nav>
            //    <ul>
            //      <li><a>page</a></li>
            //      <li><a>page</a></li>
            //      ...
            //    </ul>
            // <nav>

        }
    }
}
