﻿using System.Web;
using System.Web.Mvc;

namespace DevopsFyc1112
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
