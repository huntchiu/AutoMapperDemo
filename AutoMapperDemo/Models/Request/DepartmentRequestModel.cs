using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Models.Request
{
    public class DepartmentRequestModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
    }
}