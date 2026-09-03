using AutoMapper;
using EmployeeManagement.Services.DTOs;
using EmployeeManagement.Data.Entities;

namespace EmployeeManagement.Api.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<AddEmployeeDto, Employee>();
        }
    }
}