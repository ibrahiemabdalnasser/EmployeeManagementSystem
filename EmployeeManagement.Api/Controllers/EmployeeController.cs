using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Services.DTOs;
using EmployeeManagement.Api.Interfaces;
using EmployeeManagement.Services.Interfaces;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // 1. إضافة موظف (اللي عملناها في الأول)
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeeDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _employeeService.AddEmployeeAsync(dto);
            return Ok(result);
        }

        // 2. تعديل موظف (اللي لسه ضايفينها)
        [HttpPut("UpdateEmployee/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] AddEmployeeDto dto)
        {
            var result = await _employeeService.UpdateEmployeeAsync(id, dto);
            if (result == "الموظف مش موجود!") return NotFound(result);
            return Ok(result);
        }

        // 3. حذف موظف (اللي لسه ضايفينها)
        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployeeAsync(id);
            if (result == "الموظف مش موجود!") return NotFound(result);
            return Ok(result);
        }
    }
}