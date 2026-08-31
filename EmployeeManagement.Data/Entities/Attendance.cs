using System;

namespace EmployeeManagement.Data.Entities
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan CheckinTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; } 

        // Foreign Key
        public int EmployeeID { get; set; }

        // Navigation Property
        public Employee Employee { get; set; }
    }
}