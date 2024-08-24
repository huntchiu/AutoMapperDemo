using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Models.DTOs;
using AutoMapperDemo.Models.Entities;
using AutoMapperDemo.Models.Response;
using AutoMapperDemo.Repositories;

namespace AutoMapperDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public void Create(EmployeeDTO employeeDTO)
        {
            var employee = mapper.Map<Employee>(employeeDTO);
            employeeRepository.Add(employee);
        }


        public IEnumerable<EmployeeDTO> GetAll()
        {
            var employees = employeeRepository.GetAll();
            var employeeDTOs = mapper.Map<IEnumerable<EmployeeDTO>>(employees);
            return employeeDTOs;
        }
        
        
    }
}