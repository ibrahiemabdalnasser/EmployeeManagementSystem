using EmployeeManagement.Api.DTOs;

namespace EmployeeManagement.Api.Interfaces
{
    public interface IDepartmentService
    {
        public Task<string> AddDepartmentAsync(AddDeparmentDto dto);
        /*
        Task<string> UpdateDepartmentAsync(int id, AddDeparmentDto dto);
        Task<string> DeleteDepartmentAsync(int id);
        */
    }
}