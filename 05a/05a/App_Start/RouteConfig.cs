using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _05a
{    
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "C01",
                url: "CResearch/{action}",
                defaults: new { controller = "CResearch", action = "C01" }
                );

            routes.MapRoute(
                name: "M03",
                url: "V3/{controller}/{id}/{action}",
                defaults: new { controller = "MResearch", action = "M03", id = UrlParameter.Optional },
                constraints: new { id = @"X?" }
                );

            routes.MapRoute(
                name: "M02",
                url: "V2/{controller}/{action}",
                defaults: new { controller = "MResearch", action = "M02" },
                constraints: new { action = "M02|M01" }
                );

            routes.MapRoute(
                name: "M01",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional },
                constraints: new { id = @"1?"}
                );


        }
    }
}
