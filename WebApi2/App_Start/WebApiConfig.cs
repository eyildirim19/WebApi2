using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
            name: "RotaRoute", // routing adı (url adı)
            routeTemplate: "api/{controller}/{action}/{id}", // Url Formatı...
            defaults: new { controller = "Rota", id = RouteParameter.Optional } // hangi kontroller için ve hangi parameterler tanımlı onun adı...
            );

            // Url formatlarını buradan yapıyoruz...
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
