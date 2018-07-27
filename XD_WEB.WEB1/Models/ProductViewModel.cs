using System;

namespace XD_WEB.WEB1.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public long CategoryID { set; get; }

        public string Image { set; get; }

        public string MoreImages { set; get; } // kiểu xml -->XElement

        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }  //?có thể null
        public int? Warranty { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public DateTime? CreatedDate { set; get; } // cho phép null

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public string Tags { set; get; }
        public int Quantity { set; get; }

        public virtual ProductCategoryViewModel ProductCategory { set; get; }
    }
}