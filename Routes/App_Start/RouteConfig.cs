using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // localhost/news
            routes.MapRoute(
                name: "News",
                url:"news/",
                defaults: new { controller = "Home", action = "News"}
                );

            //category in HomeController public ActionResult ShowCategory(string category)
            // localhost/news/category
            routes.MapRoute(
                name: "Show specific category",
                url:"news/{category}/",
                defaults: new { controller = "Home", action = "ShowCategory"}
                );

            // localhost/news/category/new
            routes.MapRoute(
                name: "News name",
                url: "news/{category}/{title}-{noticeId}/",
                defaults: new { controller = "Home", action = "ShowNew" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
