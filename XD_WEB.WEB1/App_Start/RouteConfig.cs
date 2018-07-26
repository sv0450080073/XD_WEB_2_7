using System.Web.Mvc;
using System.Web.Routing;

namespace XD_WEB.WEB1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Login",
               url: "Login.html",
               defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers"}
               
               );
            routes.MapRoute(
              name: "About",
              url: "gioi-thieu.html",
              defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional }
             
          );

            routes.MapRoute(
               name: "ProductCategory",
               url: "{alias}.pc-{id}.html",
               defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional }
             
           );

          
            routes.MapRoute(
               name: "Product",
               url: "{alias}.p-{id}.html",
               defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional }
             
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  namespaces: new[] { "XD_WEB.WEB1.Controllers" }
            );
        }
    }
}