using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.Data;
using AutoMapperDemo.Models.Entities;

namespace AutoMapperDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        
        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}