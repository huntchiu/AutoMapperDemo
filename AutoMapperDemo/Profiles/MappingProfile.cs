using AutoMapper;
using AutoMapperDemo.Models.DTOs;
using AutoMapperDemo.Models.Entities;
using AutoMapperDemo.Models.Request;
using AutoMapperDemo.Models.Response;

namespace AutoMapperDemo.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // 定義Employee和EmployeeDTO之間的雙向映射
            CreateMap<Employee, EmployeeDTO>().ReverseMap();

            // 定義Employee和EmployeeResponseModel之間的映射 ，並且將Employee的FirstName和LastName組合成FullName
            CreateMap<EmployeeDTO, EmployeeResponseModel>()
                .ForMember(dest => dest.FullName,
                    opt =>
                        opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            // 定義EmployeeRequestModel和EmployeeDTO之間的映射
            CreateMap<EmployeeRequestModel, EmployeeDTO>();


            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<DepartmentDTO, DepartmentResponseModel>().ReverseMap();
            CreateMap<DepartmentResponseModel, DepartmentDTO>().ReverseMap();

        }
    }
}

/*
Entity (Employee) ↔ DTO (EmployeeDTO)
DTO (EmployeeDTO) → ResponseModel (EmployeeResponseModel)
RequestModel (EmployeeRequestModel) → DTO (EmployeeDTO)
*/
