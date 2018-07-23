using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [Required]
        public long CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [Column(TypeName = "xml")]
        public string MoreImages { set; get; } // kiểu xml -->XElement

        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }  //?có thể null
        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public string Tags { set; get; }

        //khóa ngoại
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        /*public virtual IEnumerable<Order> Orders { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }*/ //khóa chính tham chiếu
    }
}