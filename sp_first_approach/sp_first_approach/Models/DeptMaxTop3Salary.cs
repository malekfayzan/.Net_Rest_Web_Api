using System;
using System.Collections.Generic;

namespace sp_first_approach.Models
{
    public partial class DeptMaxTop3Salary
    {
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
