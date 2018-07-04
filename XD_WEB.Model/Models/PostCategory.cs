using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XD_WEB.Model.Abstract;

namespace XD_WEB.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        public string Description { set; get; }
        public string ParentID { set; get; }
        public string DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        //KHÓA CHÍNH
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}