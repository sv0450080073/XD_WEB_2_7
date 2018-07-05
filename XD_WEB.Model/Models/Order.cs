using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }

        public DateTime? CreatedDate { set; get; }

        [Required]
        public long CustomerID { set; get; }

        [Required]
        [MaxLength(50)]
        public string ShipName { set; get; }
        [MaxLength(256)]
        public string ShipMobile { set; get; }
        [MaxLength(256)]
        public string ShipAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string ShipEmail { set; get; }

        public int? Status { set; get; }

        //khóa chính vs bảng OrderDetail
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}