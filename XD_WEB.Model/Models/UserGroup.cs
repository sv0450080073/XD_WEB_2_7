using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("UserGroups")]
    public class UserGroup
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Name { set; get; }

        public virtual IEnumerable<User> Users { set; get; } //khóa chính
    }
}