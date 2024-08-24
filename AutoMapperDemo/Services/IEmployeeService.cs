using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.Models.DTOs;

namespace AutoMapperDemo.Services
{
    public interface IEmployeeService
    {
        void Create(EmployeeDTO employeeDto);
        
        IEnumerable<EmployeeDTO> GetAll();
    }
}