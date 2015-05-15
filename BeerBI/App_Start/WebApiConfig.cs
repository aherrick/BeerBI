using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData;
using System.Web.OData.Extensions;
using BeerBI.Data;

namespace BeerBI.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // odata routing goodness

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<BeerBI.Data.Repository.Beer>("Beer");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: builder.GetEdmModel());
        }
    }
}