using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.DTOs
{
    public class DepartmentDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        // public int NumberOfEmployees { get; set; }
        // public IEnumerable<EmployeeDTO> Employees { get; set; }
    }
}


// 如果要在視圖中顯示部門列表，並且要顯示每個部門中的員工數，
// 則可以在 DepartmentDTO 類中包含一個表示部門中員工數的屬性,
// 或者，您可以在 DepartmentDTO 類中包含一個 EmployeeDTO 對象的列表，以傳輸部門中所有員工的數據。

// 注意：雙向使用相同的 DepartmentDTO 類進行數據傳輸