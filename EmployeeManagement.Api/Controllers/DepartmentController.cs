using EmployeeManagement.Api.DTOs;
using EmployeeManagement.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // 1. إضافة قسم (اللي عملناها في الأول)
        [HttpPost("AddDepartment")]
        public async Task<IActionResult> AddDepartment([FromBody] AddDeparmentDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _departmentService.AddDepartmentAsync(dto);
            return Ok(result);
        }
    }
}
