using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XD_WEB.Model.Abstract;

namespace XD_WEB.Model.Models
{
    [Table("Users")]
    public class User : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }

        [Required]
        public string UserName { set; get; }

        [Required]
        public string PassWord { set; get; }

        [Required]
        public string GroupID { set; get; }

        [Required]
        public string Name { set; get; }

        public string Address { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }

        [ForeignKey("GroupID")] //khóa ngoại
        public virtual UserGroup UserGroup { set; get; }
    }
}