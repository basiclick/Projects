using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CCSVolunteerMVC.Models;

namespace CCSVolunteerMVC.Models
{
    public class Ethnicity
    {
        public int ethnicityID { get; set; }
        public string ethName { get; set; }

        public virtual ICollection<Volunteer> volunteers { get; set; }
    }
}