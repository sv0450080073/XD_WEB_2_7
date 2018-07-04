using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_WEB.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public string IPAddress { set; get; }
    }
}
