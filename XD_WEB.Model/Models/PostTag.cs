using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order =1)]
    
        public int PostID { set; get; }
        [Key]
        [Column(TypeName="varchar",Order =2)]
        [MaxLength(256)]
        public string TagID { set; get; }

        //khóa ngoại
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}