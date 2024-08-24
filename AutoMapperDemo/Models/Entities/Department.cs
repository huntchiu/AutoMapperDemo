using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        // 在一對多關係中，外鍵通常定義在 "多" 端的實體中（即 Employee 實體）, ICollection<Employee> Employees 不会对表结构产生影响
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}