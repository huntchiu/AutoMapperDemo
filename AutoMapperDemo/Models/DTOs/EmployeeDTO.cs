using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.DTOs
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal Salary { get; set; }
        public Guid DepartmentId { get; set; }
        public DepartmentDTO? Department { get; set; }
    }
}
// 此類用於在數據訪問層和業務邏輯層之間傳輸數據。它應該只包含特定操作所需的屬性。
// 比EmployeeRequestModel 多了一个DepartmentDTO，因为需要创建的实体，包含一对多的关系