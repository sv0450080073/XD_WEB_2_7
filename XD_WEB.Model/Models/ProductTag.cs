using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductID { set; get; }

        public string TagID { set; get; }

        //khóa ngoại

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}