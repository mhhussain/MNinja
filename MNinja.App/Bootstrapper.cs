using System;
using System.Web;
using MNinja.App;
using MNinja.App.App_Start;

[assembly: PreApplicationStartMethod(typeof(Bootstrapper), "Initialize")]
namespace MNinja.App
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            RouteConfig.RegisterRoutes();
        }
    }
}
