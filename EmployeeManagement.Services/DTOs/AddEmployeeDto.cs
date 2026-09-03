namespace EmployeeManagement.Services.DTOs
{
    public class AddEmployeeDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // دول الـ Foreign Keys عشان نربط الموظف بالقسم والصلاحية بتاعته
        public int DepId { get; set; }
        public int RoleId { get; set; }
    }
}