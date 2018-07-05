using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(256)]
        [Required]
        public string Type { set; get; }
    }
}