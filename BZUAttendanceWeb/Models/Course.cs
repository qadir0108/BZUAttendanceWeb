using System.ComponentModel.DataAnnotations;

namespace BZUAttendanceWeb.Models
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; } // IT-403
        public string Name { get; set; } // Mobile App Development
        public int Semester { get; set; } // 7

    }
}
