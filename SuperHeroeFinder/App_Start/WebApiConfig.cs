using System.Web.Http;
using System.Web.Http.Dispatcher;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SuperHeroeFinder.DependencyInjection;

namespace SuperHeroeFinder
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            GlobalConfiguration.Configuration.Services.Replace(
    typeof(IHttpControllerActivator),
    new PoorMansCompositionRoot());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                PreserveReferencesHandling.Objects;

            json.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            json.SerializerSettings.ContractResolver
                = new CamelCasePropertyNamesContractResolver();

            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy =
                IncludeErrorDetailPolicy.Always;

        }
    }
}
