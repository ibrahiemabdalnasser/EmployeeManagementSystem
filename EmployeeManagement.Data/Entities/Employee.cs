using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Data.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        // Foreign Keys
        public int DepId { get; set; }
        public int RoleId { get; set; }

        public Department Department { get; set; }
        public Role Role { get; set; }

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}