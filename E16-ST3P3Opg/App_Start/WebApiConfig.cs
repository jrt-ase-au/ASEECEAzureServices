﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace E16_ST3P3Opg
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "st3p3eventservice/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            /*
            * http://www.asp.net/web-api/overview/formats-and-model-binding/json-and-xml-serialization
            */
            config.Formatters.XmlFormatter.UseXmlSerializer = false;


            /*
             * http://johnnycode.com/2012/04/10/serializing-circular-references-with-json-net-and-entity-framework/
             * http://stackoverflow.com/questions/20980241/how-do-i-sub-in-json-net-as-model-binder-for-asp-net-mvc-controllers
             * 
             */
            //var jsonSerializerSettings = new JsonSerializerSettings
            //{
            //    PreserveReferencesHandling = PreserveReferencesHandling.Objects
            //};
           
            //config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            //config.Formatters.Add(new J);
           

            
        }
    }
}
