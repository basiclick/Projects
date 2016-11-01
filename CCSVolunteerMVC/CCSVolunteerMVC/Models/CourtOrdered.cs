using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class CourtOrdered
    {
        public int courtOrderedID { get; set; }
        public int? volID { get; set; }
        public virtual Volunteer volunteer { get; set; }
        public string crtOrderCaseNumber { get; set; }
        public int crtOrderedHoursRequired { get; set; }
        public DateTime crtOrderedStartDate { get; set; }
        public int crtOrderedSexOrViolentCrime { get; set; }
        public int crtOrderedOneMonthLimit { get; set; }
    }
}