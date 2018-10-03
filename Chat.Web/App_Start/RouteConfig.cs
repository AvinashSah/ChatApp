using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Chat.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Route for Chatting Page
            routes.MapRoute(
                "AngularChat",
                "AngularChat/Chat",
                new { controller = "AngularChat", action = "Chat" });

            //All Other routes will be transferred to this URL
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AngularChat", action = "Chat", id = UrlParameter.Optional }
            );
        }
    }
}
