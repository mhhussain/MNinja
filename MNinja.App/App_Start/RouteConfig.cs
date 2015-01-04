using System.Web.Http;

namespace MNinja.App.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes()
        {
            var routes = GlobalConfiguration.Configuration.Routes;

            routes.MapHttpRoute(
                name: "RunApplication",
                routeTemplate: "{controller}/{action}",
                defaults: new {controller = "Main", action = "Run"}
                );
        }
    }
}
