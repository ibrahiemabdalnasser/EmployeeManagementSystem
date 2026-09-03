
using EmployeeManagement.Services.DTOs;
using EmployeeManagement.Services.Interfaces;
namespace EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        // دي الدالة اللي هتستقبل الـ DTO وتضيف الموظف
        Task<string> AddEmployeeAsync(AddEmployeeDto dto);
        Task<string> UpdateEmployeeAsync(int id, AddEmployeeDto dto);
        Task<string> DeleteEmployeeAsync(int id);
    }
}
