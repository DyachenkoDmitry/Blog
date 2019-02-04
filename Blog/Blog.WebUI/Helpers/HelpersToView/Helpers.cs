using System.Web.Mvc;
using Blog.WebUI.Helpers.Enum;

namespace Blog.WebUI.Helpers.HelpersToView
{
    public static  class Helpers
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items, ListTags sort,  object htmlAttributes = null)
        {
            var list = new TagBuilder(sort.ToString());
            foreach (string item in items)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(item);
                list.InnerHtml += li.ToString();
            }
            list.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return new MvcHtmlString(list.ToString());
        }
    }
}