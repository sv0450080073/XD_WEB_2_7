using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Department { set; get; }

        [MaxLength(256)]
        public string Skype { set; get; }

        [MaxLength(256)]
        public string Mobile { set; get; }

        [MaxLength(256)]
        public string Email { set; get; }

        [MaxLength(256)]
        public string Yahoo { set; get; }

        [MaxLength(256)]
        public string Facebook { set; get; }

        public bool? Status { set; get; }
    }
}