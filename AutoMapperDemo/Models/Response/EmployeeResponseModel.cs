using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.Response
{
    public class EmployeeResponseModel
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public decimal Salary { get; set; }
        public string? DepartmentName { get; set; }
    }
}
// 這個類用於將數據從業務邏輯層傳輸到表示層。它應該只包含呈現視圖所需的屬性。