using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidyaCat2.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Developers by region
            routes.MapRoute(
                name: "Region",
                url: "{controller}/{action}/{region}");

            // Developers by type
            routes.MapRoute(
                name: "Type",
                url: "{controller}/{action}/{type}");

            // Developers or Platforms by status
            routes.MapRoute(
                name: "Status",
                url: "{controller}/{action}/{status}");

            // Games or Platforms by year
            routes.MapRoute(
                name: "Year",
                url: "{controller}/{action}/{year}");

            // Games by genre
            routes.MapRoute(
                name: "Genre",
                url: "{controller}/{action}/{genre}");

            // Games by rating
            routes.MapRoute(
                name: "Rating",
                url: "{controller}/{action}/{rating}");

            // Platforms by brand
            routes.MapRoute(
                name: "Brand",
                url: "{controller}/{action}/{brand}");
        }
    }
}
