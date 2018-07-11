using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Content { set; get; }

        [MaxLength(256)]
        public string MetaKeyWord { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool? Status { set; get; }
    }
}