﻿using System.Web;
using System.Web.Mvc;

namespace E16_ST3ITS3ReExamSP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
