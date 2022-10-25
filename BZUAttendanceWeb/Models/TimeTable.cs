namespace BZUAttendanceWeb.Models
{
    public class TimeTable
    {
        public string Room { get; set; } // G3 / F2 / CL
        public string TeacherCNIC { get; set; } // 3630446517241
        public string TeacherName { get; set; } // Kamran Qadir

        public string CourseCode { get; set; } // IT-403

        // 1 - 0830-1000
        // 2 - 1000-1130
        // 3 - 1200-1330
        // 4 - 1330-1500
        public string TimeSlot { get; set; } // 3

    }
}
