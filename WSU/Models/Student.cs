using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // allows up to use data anotatins
using System.ComponentModel.DataAnnotations.Schema; // specific for database more than visual studio
namespace WSU.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]

        [StringLength(50, MinimumLength =1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage= "First name cannot be longer than 50 characters")]
        [Column("FirstName")]// change column in database to FirstName  using System.ComponentModel.DataAnnotations.Schema
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)] // date type that sql server understands
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")] // display changes do not require database synce we are just changing the appearance of the fields
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName   // not in database but have access to it as a property in code
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public virtual ICollection<Enrollment>  Enrollments { get; set; }// student has many enrollments ICollection of them
    }
}