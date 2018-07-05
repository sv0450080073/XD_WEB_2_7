using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
    
        public int PostID { set; get; }
        [Key]
        [Column(TypeName="varchar")]
        [MaxLength(256)]
        public string TagID { set; get; }

        //khóa ngoại
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}