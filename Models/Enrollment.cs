
namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }


    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //put the navigation properties of the foreign keys
        // Course to CourseID and Student to StudentID

        public Course Course { get; set; }
        public Student Student { get; set; }
        
        
    }
}