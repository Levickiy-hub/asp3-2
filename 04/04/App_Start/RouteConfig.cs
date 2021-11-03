using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _04
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Phone",
              url: "{controller}/{action}",
              defaults: new { controller = "Phone", action = "Index" }
          );
            routes.MapRoute(
                "404-PageNotFound",
                "{*url}",
                new { controller = "Error", action = "NotFound" }
            );
        }
    }
}
