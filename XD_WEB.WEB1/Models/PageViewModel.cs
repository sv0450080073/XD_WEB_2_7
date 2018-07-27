using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XD_WEB.WEB1.Models
{
    public class PageViewModel
    {
        public int ID { set; get; }

       
        public string Name { set; get; }

       
        public string Content { set; get; }

       
        public string MetaKeyWord { set; get; }

        
        public string MetaDescription { set; get; }

        
        public string Alias { set; get; }

        public bool? Status { set; get; }
    }
}
    