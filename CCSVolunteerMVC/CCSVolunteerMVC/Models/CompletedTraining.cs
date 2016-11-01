using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class CompletedTraining
    {
        public int completedTrainingID { get; set; }

        public int volID { get; set; }

        public virtual Volunteer volunteer { get; set; }

        public int volTrnID { get; set; }

        public virtual VolunteerTraining volunteerTraining { get; set; }

        public DateTime cmpTrnDate { get; set; }

        public string cmpTrnComments { get; set; }


    }
}