﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CCSVolunteerMVC.Models
{
    public class CompletedTraining
    {
        public int completedTrainingID { get; set; }

        public int volID { get; set; }

        public virtual Volunteer volunteer { get; set; }

        public int volTrnID { get; set; }

        public virtual VolunteerTraining volunteerTraining { get; set; }

        [Display(Name = "Completed Training Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime cmpTrnDate { get; set; }

        [Display(Name = "Completed Training Comments")]
        [StringLength(100, MinimumLength = 1)]
        public string cmpTrnComments { get; set; }


    }
}