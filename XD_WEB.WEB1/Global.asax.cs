using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using XD_WEB.WEB1.Mappings;

namespace XD_WEB.WEB1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //autmapper
            AutoMapper.Mapper.Initialize(m => m.AddProfile<MappingProfile>());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //AutomapperConfiguration.Configure();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //mapping
            //MappingConfig.RegisterMapping();
        }
    }

    // thử rồi ko thành
    /* public class MappingConfig
     {
         public static AutoMapper.IMapper Mapping;
         public static void RegisterMapping()
         {
             var mapperconfig = new AutoMapper.MapperConfiguration(config =>
              {
                  config.CreateMap<Post, PostViewModel>();
                  config.CreateMap<PostCategory, PostCategoryViewModel>();
                  config.CreateMap<Tag, TagViewModel>();
              });
             Mapping = mapperconfig.CreateMapper();
         }
     }*/
}