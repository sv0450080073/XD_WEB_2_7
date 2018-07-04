using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        public string TagID { set; get; }
        //khóa ngoại 
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
    }
}