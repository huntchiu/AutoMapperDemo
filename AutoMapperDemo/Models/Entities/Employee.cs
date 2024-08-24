using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // 指定 DepartmentId 屬性是 Department 導覽屬性的外鍵
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }

        public Department Department { get; set; } = new();
    }
}