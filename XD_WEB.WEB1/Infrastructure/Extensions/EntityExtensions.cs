using XD_WEB.Model.Models;
using XD_WEB.WEB1.Models;

namespace XD_WEB.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            /**  public int ID { set; get; }
          public string Name { set; get; }
          public string Alias { set; get; }
          public string Description { set; get; }
          public int? ParentID { set; get; }
          public int? DisplayOrder { set; get; }
          public string Image { set; get; }
          public bool? HomeFlag { set; get; }

            DateTime? CreatedDate { set; get; }
            string CreatedBy { set; get; }
            DateTime? UpdatedDate { set; get; }
            string UpdatedBy { set; get; }
            string MetaKeyword { set; get; }
            string MetaDescription { set; get; }
            bool Status { set; get; }*/

            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.Description = postCategoryVm.Description;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreatedBy = postCategoryVm.CreatedBy;
            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;
            postCategory.UpdatedBy = postCategoryVm.CreatedBy;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            /* public int ID { set; get; }
            public string Name { set; get; }
            public string Alias { set; get; }
            public int CategoryID { set; ge

            public string Image { set; get; }
            public string Description { set; get; }
            public string Content { set; get; }
            public bool? HomeFlag { set; get; }
            public bool? HotFlag { set; get; }
            public int? ViewCount { set; get; }
            */
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Image = postVm.Image;
            post.Description = postVm.Description;
            post.Content = postVm.Content;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = postVm.CreatedDate;
            post.CreatedBy = postVm.CreatedBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.UpdatedBy = postVm.CreatedBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
        }
    }
}