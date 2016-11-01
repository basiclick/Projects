using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WSU.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // we want to define PK not automatated when we create a new course
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)] // between 3 and 50 characters
        public string Title { get; set; }
        [Range(0, 5)] // CANNOT do a range on money or integers only does integers
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; } // can only doing lazy loading on virtual objects
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}