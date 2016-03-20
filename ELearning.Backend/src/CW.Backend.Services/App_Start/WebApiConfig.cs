﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin.Security.OAuth;

namespace CW.Backend.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
//            config.SuppressDefaultHostAuthentication();
//            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
//
//            // Web API routes
//            config.MapHttpAttributeRoutes();
//
//            var cors = new EnableCorsAttribute("*", "*", "GET,POST");
//            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
