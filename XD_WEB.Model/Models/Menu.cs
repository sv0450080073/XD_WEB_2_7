using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key] // khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tự tăng
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required] // ko null
        public int GroupID { set; get; }

        [ForeignKey("GroupID")] // khóa ngoại
        public virtual MenuGroup MenuGroup { set; get; }

        public string Target { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}