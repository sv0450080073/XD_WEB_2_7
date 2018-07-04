﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using XD_WEB.Model.Abstract;

namespace XD_WEB.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key] // khóa
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // tự tăng
        public long ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; } // kiểu xml -->XElement
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }  //?có thể null
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        //khóa ngoại 
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual IEnumerable<Order>Orders { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; } //khóa chính tham chiếu

    }
}