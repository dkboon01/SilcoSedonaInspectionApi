﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SilcoSedonaInspectionApi;


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
            //added
            //config.SuppressDefaultHostAuthentication();
        }
    }
}
