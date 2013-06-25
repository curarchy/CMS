using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CMS.Model
{
    public class ArticleModel
    {
        public string GetArticleID()
        {
            HttpContext Context = HttpContext.Current;
            if (Context.Request["aid"] != null)
                return Context.Request["aid"];
            else
            {
                return GetArticleIDFromURL(Context.Request.RawUrl);
            }
        }

        /// <summary>
        /// 通过URL取得文章ID号
        /// </summary>
        /// <returns></returns>
        public string GetArticleIDFromURL(string url)
        {
            return string.Empty;
        }
    }
}
