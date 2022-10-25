﻿namespace BZUAttendanceWeb.Models
{
    public class Attendance
    {
        public string RollNumber { get; set; } // LDTTE1919
        public string TimeSlot { get; set; } // 3
        public DateTime Date { get; set; } // 20221021133000  yyyyMMddhhmmss
        public string Status { get; set; } // PRESENT
    }

    public enum StatusEnum
    {
        ABSENT,
        PRESENT,
        LEAVE
    }
}
