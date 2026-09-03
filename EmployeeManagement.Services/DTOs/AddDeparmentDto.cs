using EmployeeManagement.Data.Entities;

namespace EmployeeManagement.Api.DTOs
{
    public class AddDeparmentDto
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}