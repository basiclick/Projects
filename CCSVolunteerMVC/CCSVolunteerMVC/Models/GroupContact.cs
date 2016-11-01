using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class GroupContact
    {
        public int groupContactID { get; set; }
        public string grpContName { get; set; }
        public int contTypeID { get; set; }
        public virtual ContactType contactType { get; set; }
        public int? volGroupID { get; set; }
        public virtual VolunteerGroup volunteerGroup { get; set; }
        public string grpContInfo { get; set; }
    }
}