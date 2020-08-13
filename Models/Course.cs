using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Add the Navigation property of Enrollments.
        // A course may have many enrollments...
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}