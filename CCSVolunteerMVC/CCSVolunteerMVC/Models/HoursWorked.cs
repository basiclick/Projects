using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class HoursWorked
    {
        public int hoursWorkedID { get; set; }
        public int posID { get; set; }
        //todo add postion location object

        public string hrsWrkdIDType { get; set; }
        public DateTime hrsWrkdTimeIn { get; set; }
        public DateTime hrsWrkdTimeOut { get; set; }
        public int userAcctID { get; set; }
        //todo find out what object to tie to userAcctID for code first

        public DateTime modifiedOn { get; set; }
        public DateTime hrsWrkedSchedDate { get; set; }
        public int volID { get; set; }
        public virtual Volunteer volunteer { get; set; }
        public int volGrpID { get; set; }
        //todo vol group object
        public decimal hrsWrkdQty { get; set; }

        public virtual PositionLocation positionLocation { get; set; }
    }
}