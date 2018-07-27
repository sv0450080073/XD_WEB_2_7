using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XD_WEB.WEB1.Models
{
    public class ContactDetailViewModel
    {
        public int ID { set; get; }

        [Required(ErrorMessage ="Tên không được trống ")]
        public string Name { set; get; }

        [MaxLength(50,ErrorMessage ="SĐT phải <50 kí tự")]
        public string Phone { set; get; }

        [MaxLength(250, ErrorMessage = "Email phải <250 kí tự")]
        public string Email { set; get; }
        [MaxLength(250, ErrorMessage = "Address phải <250 kí tự")]
        public string Address { set; get; }

        public string Other { set; get; }

    

        public double? Lat { set; get; }
        

        public double? Lng { set; get; }

        public bool Status { set; get; }


    }
}