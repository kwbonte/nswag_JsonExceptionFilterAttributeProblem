﻿using System.Web;
using System.Web.Mvc;

namespace webapi_excludeJSONFilter_problem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
