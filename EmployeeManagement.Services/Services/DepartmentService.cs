using AutoMapper;
using EmployeeManagement.Api.DTOs;
using EmployeeManagement.Api.Interfaces;
using EmployeeManagement.Data;
using EmployeeManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DepartmentService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> AddDepartmentAsync(AddDeparmentDto dto)
        {
            // 1. تحويل الـ DTO إلى Entity أصلية
            var employee = _mapper.Map<Employee>(dto);

            // 2. إضافة الموظف للداتا بيز
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

            return "تم إضافة الموظف بنجاح!";
        }
    }
}
