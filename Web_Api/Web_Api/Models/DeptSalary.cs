using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class DeptSalary
    {
        public int? DepartmentUserCount { get; set; }
        public decimal? MaximumSalary { get; set; }
        public decimal? MinimumSalary { get; set; }
    }
}
