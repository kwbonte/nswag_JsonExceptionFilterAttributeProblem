using System;
using System.Collections.Generic;
using System.Linq;
using NSwag.AspNet.WebApi;
using System.Web.Http;


namespace webapi_excludeJSONFilter_problem
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            AddGlobalFilters(config);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void AddGlobalFilters(HttpConfiguration config)
        {
            config.Filters.Add(new JsonExceptionFilterAttribute());
        }


    }
}
