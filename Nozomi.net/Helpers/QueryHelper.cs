using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace Nozomi.net.Helpers
{
    public static class QueryHelper
    {
        /// <summary>
        /// Constructs a QueryString (string).
        /// Consider this method to be the opposite of "System.Web.HttpUtility.ParseQueryString"
        /// </summary>
        public static string ConstructQueryString(NameValueCollection parameters)
        {
            var items = new List<string>();

            foreach (string name in parameters)
                items.Add(string.Concat(name, "=", System.Web.HttpUtility.UrlEncode(parameters[name])));

            return string.Join("&", items.ToArray());
        }
    }
}