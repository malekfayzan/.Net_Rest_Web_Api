using System;
using System.Collections.Generic;

namespace web_api_sp.Models
{
    public partial class DeptMaxTop3Salary
    {
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
