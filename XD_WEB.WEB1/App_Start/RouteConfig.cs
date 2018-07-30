using System.Web.Mvc;
using System.Web.Routing;

namespace XD_WEB.WEB1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // BotDetect requests must not be routed
            routes.IgnoreRoute("{*botdetect}", new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
               name: "Contact",
               url: "lien-he.html",
               defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers" }

               );

            routes.MapRoute(
               name: "Search",
               url: "tim-kiem.html",
               defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers" }

               );

            routes.MapRoute(
               name: "Login",
               url: "Login.html",
               defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers"}
               
               );
            //điều hướng trang đơn lẻ
            routes.MapRoute(
              name: "Page",
              url: "trang/{alias}.html",
              defaults: new { controller = "Page", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "XD_WEB.WEB1.Controllers" }

          );

            routes.MapRoute(
               name: "ProductCategory",
               url: "{alias}.pc-{id}.html",
               defaults: new {controller = "Product", action = "Category", id = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers" }

           );

          
            routes.MapRoute(
               name: "Product",
               url: "{alias}.p-{mid}.html",
               defaults: new { controller = "Product", action = "Detail", mid = UrlParameter.Optional },
               namespaces: new[] { "XD_WEB.WEB1.Controllers" }

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