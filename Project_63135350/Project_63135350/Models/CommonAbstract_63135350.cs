using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_63135350.Models
{
    public abstract class CommonAbstract_63135350
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
