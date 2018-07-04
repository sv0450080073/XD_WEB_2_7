using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}