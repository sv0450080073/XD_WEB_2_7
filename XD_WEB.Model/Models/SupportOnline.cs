using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_WEB.Model.Models
{
    [Table("SupportOnlines")]
   public  class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        public string Department { set; get; }
        public string Skype { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Yahoo { set; get; }
        public string Facebook { set; get; }
        public bool? Status { set; get; }
    }
}
