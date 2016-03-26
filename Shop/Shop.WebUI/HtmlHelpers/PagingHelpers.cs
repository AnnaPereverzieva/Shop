using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Shop.WebUI.Models;

namespace Shop.WebUI.HtmlHelpers
{
    static public class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pareUrl)
        {
            var tt=pareUrl(5);
            StringBuilder result=new StringBuilder();
            for (int i = 0; i < pagingInfo.TotalPages; i++)
            {
                TagBuilder tag =new TagBuilder("a");
                tag.MergeAttribute("href", pareUrl(i));
                tag.InnerHtml = i.ToString();
                if(i==pagingInfo.CurrentPage)
                    tag.AddCssClass("selected");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}