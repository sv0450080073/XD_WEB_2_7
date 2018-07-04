using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XD_WEB.Model.Abstract;

namespace XD_WEB.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        //khai báo khóa chính /
        public virtual IEnumerable<Product> Products { set; get; }
    }
}