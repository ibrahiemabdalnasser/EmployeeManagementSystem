using AutoMapper;
using EmployeeManagement.Data.Entities;
// السطر اللي جاي ده بتاع الداتا بيز، لو ضرب خط أحمر اعمله Ctrl + . واختار الـ using الصح
using EmployeeManagement.Data;
using EmployeeManagement.Data.Entities; // عشان يشوف كلاس الـ Employee والـ AppDbContext
using EmployeeManagement.Services.DTOs; // عشان يشوف الـ AddEmployeeDto بعد ما نقلناه لمكانه الصح
using EmployeeManagement.Services.DTOs;
using EmployeeManagement.Services.Interfaces;
namespace EmployeeManagement.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<string> UpdateEmployeeAsync(int id, AddEmployeeDto dto)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return "الموظف مش موجود!";

            // تحديث البيانات
            employee.Name = dto.Name;
            employee.Email = dto.Email;
            employee.Salary = dto.Salary;
            employee.DepId = dto.DepId;
            employee.RoleId = dto.RoleId;

            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return "تم تعديل بيانات الموظف بنجاح!";
        }

        public async Task<string> DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return "الموظف مش موجود!";

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return "تم حذف الموظف بنجاح!";
        }
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> AddEmployeeAsync(AddEmployeeDto dto)
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