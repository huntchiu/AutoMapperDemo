using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.Models.Entities;

namespace AutoMapperDemo.Repositories
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        IEnumerable<Employee> GetAll();
    }
}