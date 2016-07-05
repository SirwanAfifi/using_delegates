using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebPages;
using Antlr.Runtime.Misc;

namespace UsingDelegates.Helpers
{
    public static class Helper
    {
        // public delegate HelperResult ItemTemplate<T>(T input);

        public static HelperResult Repeater<T>(this HtmlHelper html,
          IEnumerable<T> items,
          Func<T, HelperResult> itemTemplate,
          Func<T, HelperResult> alternatingitemTemplate = null)
        {
            return new HelperResult(writer =>
            {
                int i = 0;
                foreach (var item in items)
                {
                    var func = i % 2 == 0 ? itemTemplate : alternatingitemTemplate;
                    func(item).WriteTo(writer);
                    i++;
                }
            });
        }
    }
}