using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XD_WEB.Model.Models
{
    [Table("Credentials")]
    public class Credential
    {
        [Key]
        public string UserGroupID { set; get; }

        public string RoleID { set; get; }
    }
}