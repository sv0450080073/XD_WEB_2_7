using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("MenuGroups")] // coment
    public class MenuGroup
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required] //ko cho pheeps null
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; } //quan hệ khóa ngoại
    }
}