using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace BeerBI
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

            //// New code:
            //ODataModelBuilder builder = new ODataConventionModelBuilder();
            //builder.EntitySet<Product>("Products");
            //config.MapODataServiceRoute(
            //    routeName: "ODataRoute",
            //    routePrefix: null,
            //    model: builder.GetEdmModel());
        }
    }
}
