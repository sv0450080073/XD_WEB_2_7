using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tự tăng
        public int ID { set; get; }

        [Required] //not null
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [MaxLength(256)]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? Status { set; get; }
    }
}