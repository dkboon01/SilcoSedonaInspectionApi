using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SilcoSedonaInspectionApi;
using System.Web.Http.ExceptionHandling;

namespace SilcoSedonaCustomApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableSystemDiagnosticsTracing();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new APIService.BasicAuthenticationAttribute());
            config.Services.Replace(typeof(IExceptionLogger), new CustomAPIExceptionHandling());
            //added
            //config.SuppressDefaultHostAuthentication();
        }
    }
}
