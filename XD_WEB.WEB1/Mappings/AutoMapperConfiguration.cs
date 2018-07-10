using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using XD_WEB.Model.Models;

using XD_WEB.WEB1.Models;

namespace XD_WEB.Web.Mappings
{
    public class AutomapperConfiguration


    {



        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();

            });
            var mapper = config.CreateMapper();

        }
    }
}