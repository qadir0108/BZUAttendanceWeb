using System.ComponentModel.DataAnnotations;

namespace BZUAttendanceWeb.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; } // LDTTE1919
        public int Session { get; set; } // 1923
        public string Department { get; set; } // IT
        public int Semester { get; set; } // 7
        public long CNIC { get; set; } // 3630446517241
        public string PhoneNumber { get; set; } // 03216334272
        public string Email { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public List<Attendance> attendances { get; set; }

    }

    public enum DepartmentEnum
    {
        IT,
        ENG,
        SOCI,
        PA
    }
}
