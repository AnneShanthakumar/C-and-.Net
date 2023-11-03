﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarInsurance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // ... (existing routes)

            routes.MapRoute(
                name: "Admin",
                url: "Insuree/Admin",
                defaults: new { controller = "Insuree", action = "Admin" }
            );
        }
    }
}
