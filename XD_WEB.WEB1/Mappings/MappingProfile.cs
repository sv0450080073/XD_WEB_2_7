using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XD_WEB.Model.Models;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap <Post, PostViewModel > ();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}