using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WSU.Models
{
    public class OfficeAssignment
    {
        [Key] // since pk is not called ID or OfficeAssignmentId,  we have to EXPLICITLY set the pk
        [ForeignKey("Instructor")]// foreignkey for Instructor table   looks for InstructorID in instructor table since data annatoion is for InstructorID
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }
        public virtual Instructor Instructor { get; set; } // one to one relationship with Instructor
    }
}