using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductID { set; get; }
        public long OrderID { set; get; }
        public int? Quantity { set; get; }
        public decimal Price { set; get; }

        //khóa ngoại
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
    }
}