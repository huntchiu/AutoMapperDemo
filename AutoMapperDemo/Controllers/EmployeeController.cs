using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Models.DTOs;
using AutoMapperDemo.Models.Request;
using AutoMapperDemo.Models.Response;
using AutoMapperDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private readonly IMapper mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            this.employeeService = employeeService;
            this.mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var employeeDtos = employeeService.GetAll();
            var employeeResponseModels = mapper.Map<IEnumerable<EmployeeResponseModel>>(employeeDtos);
            return Ok(employeeResponseModels);
        }
        
        
        [HttpPost]
        public IActionResult Create(EmployeeRequestModel model)
        {
            var employeeDTO = mapper.Map<EmployeeDTO>(model);
            employeeService.Create(employeeDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}