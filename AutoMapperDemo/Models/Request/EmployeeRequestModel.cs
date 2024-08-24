using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.Request
{
    public class EmployeeRequestModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal Salary { get; set; }
        public Guid DepartmentId { get; set; }
    }
}

// 這個類用於將數據從表示層傳輸到業務邏輯層。它應該只包含執行特定操作所需的屬性。