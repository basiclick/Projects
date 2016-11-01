using WSU.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace WSU.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // many to many relationship
            modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses)
           .Map(t => t.MapLeftKey("CourseID") // left hand side of equation
           .MapRightKey("InstructorID")// right hand side of equation
           .ToTable("CourseInstructor")); // many to many resolving table between them
        }
    }
}