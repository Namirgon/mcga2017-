using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASF.UI.WbSite.Constants
{
    public class DataCacheSetting
    {
        public static class Category
        {
            public const string Key = "Category";
            public static readonly TimeSpan SlidingExpiration = TimeSpan.FromHours(1);


        }


    }
}