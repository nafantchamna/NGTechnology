﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Site_Oficial
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             "sobre",
            "sobre",
            new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
             "serviços",
            "serviços",
            new { controller = "Home", action = "Time" }
            );


            routes.MapRoute(
             "contato",
            "contato",
            new { controller = "Home", action = "Contact" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
