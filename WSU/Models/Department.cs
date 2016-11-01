using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WSU.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)] // in a textbox its going to treat it as local currency
        [Column(TypeName = "money")]   // money datatype in sqlserver   smallmoney also an option
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        public int? InstructorID { get; set; } // department does not have to have any Instructors  zero or one to one relationship
        //optional because of the question mark
        public virtual Instructor Administrator { get; set; }// can still point back to instructor table and call it something else
        public virtual ICollection<Course> Courses { get; set; }
    }
}