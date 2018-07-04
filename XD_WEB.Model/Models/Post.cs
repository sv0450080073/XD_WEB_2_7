using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XD_WEB.Model.Abstract;

namespace XD_WEB.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }
        //khóa ngoại
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        public string Image { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
      

            //khóa chính
       public virtual IEnumerable<PostTag> PostTags { set; get; }

    }
}