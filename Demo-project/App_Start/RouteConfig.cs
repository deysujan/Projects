
using System.Web.Mvc;
using System.Web.Routing;

namespace Demo_project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
               name: "GetCustomer",
               url: "scs/api/getCustomer",
               defaults: new { controller = "Customer", action = "GetCustomer" },
               constraints: new { httpMethod = new HttpMethodConstraint("Get") }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


           
        }
    }
}