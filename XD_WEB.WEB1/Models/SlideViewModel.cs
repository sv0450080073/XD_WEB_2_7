using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XD_WEB.WEB1.Models
{
    public class SlideViewModel
    {
        public int ID { set; get; }

        
        public string Name { set; get; }


        public string Description { set; get; }

     
        public string Image { set; get; }

        
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }
        public bool? Status { set; get; }
        public string Content { set; get; }
    }
}