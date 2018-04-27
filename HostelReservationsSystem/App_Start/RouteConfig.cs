﻿using System.Web.Mvc;
using System.Web.Routing;

namespace HostelReservationsSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;
            routes.MapRoute("Default", "{controller}/{action}/{id}", new
            {
                controller = "Home",
                action = "HIndex",
                id = UrlParameter.Optional
            }).RouteHandler = new DashRouteHandler();
        }
    }
}
