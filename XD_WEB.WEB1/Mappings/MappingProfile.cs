using AutoMapper;
using XD_WEB.Model.Models;
using XD_WEB.WEB1.Models;

namespace XD_WEB.WEB1.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // chuyển bảng thật sang bảng view ->để hiển thị
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
            CreateMap<Product, ProductViewModel>();

            CreateMap<ProductCategory, ProductCategoryViewModel>();

            CreateMap<ProductTag, ProductTagViewModel>();
            CreateMap<Footer, FooterViewModel>();
            CreateMap<Slide, SlideViewModel>();
            CreateMap<Page, PageViewModel>();
            CreateMap<ContactDetail, ContactDetailViewModel>();

        }
    }
}