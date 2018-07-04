using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        [Required]
        public string Name { set; get; }

        public string Type { set; get; }
    }
}