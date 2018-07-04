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
        public string Name { set; get; }

        public string Content { set; get; }
        public string MetaKeyWord { set; get; }
        public string MetaDescription { set; get; }
        public bool? Status { set; get; }
    }
}