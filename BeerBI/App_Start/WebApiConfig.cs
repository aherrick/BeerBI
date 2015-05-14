using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData;
using System.Web.OData.Extensions;

namespace BeerBI.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

        //    // Web API routes
            config.MapHttpAttributeRoutes();

        //    config.Routes.MapHttpRoute(
        //    name: "DefaultApi",
        //    routeTemplate: "api/{controller}/{id}",
        //    defaults: new { id = RouteParameter.Optional }
        //);

        //    //config.Routes.MapHttpRoute("DefaultApiWithId", "Api/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
        //    //config.Routes.MapHttpRoute("DefaultApiWithAction", "Api/{controller}/{action}");




            // New code:
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<BeerBI.Data.Repository.Beer>("Beer");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: builder.GetEdmModel());

         //   config.Formatters.Add(new BrowserJsonFormatter());
        }
    }
}