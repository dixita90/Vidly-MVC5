using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*specific routes specified first then generic routes
            last argument in this route is regex for parameters
            This style of routing was used in MVC4 and for large applications you need to specify
            multiple routes. Also if you change the name of a function you need to change the route action here.
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller="Movies", action="ByReleaseDate"},
                new { year=@"\d{4}",month=@"\d{2}"});
                */

            //MVC5 style of routing
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
