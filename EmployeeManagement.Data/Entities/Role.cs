using System.Collections.Generic;

namespace EmployeeManagement.Data.Entities
{
    public class Role
    {
        public int RoleID { get; set; }
        public string Title { get; set; }

      
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}