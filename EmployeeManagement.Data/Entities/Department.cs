using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Data.Entities
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}