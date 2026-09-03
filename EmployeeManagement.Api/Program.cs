using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Data; // عشان يشوف كلاس الـ AppDbContext
// السطرين الجايين دول هما اللي هيحلوا الإيرور عشان يشوف الطبقة الجديدة
using EmployeeManagement.Services;
using EmployeeManagement.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// إعدادات الداتا بيز بتاعتك (أكيد مكتوبة عندك)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ربط الـ Interface بالـ Service (السطر ده مبنغيرش فيه حاجة)
builder.Services.AddScoped<IEmployeeService, EmployeeManagement.Services.Services.EmployeeService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();