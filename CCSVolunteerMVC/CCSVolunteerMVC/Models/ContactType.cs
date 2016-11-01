using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class ContactType
    {
        public int contactTypeID { get; set; }
        public string contTypeName { get; set; }

        public virtual ICollection<Contact> contacts { get; set; }
        public virtual ICollection<GroupContact> groupContact { get; set; }
    }
}