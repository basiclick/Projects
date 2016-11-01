using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class Contact
    {
        public int contactID { get; set; }
        public int contTypeID { get; set; }
        //todo contTYPE object

        public int? volID { get; set; }
        public virtual Volunteer volunteer { get; set; }

        public string contactInfo { get; set; }
        public int contCanContact { get; set; }
    }
}