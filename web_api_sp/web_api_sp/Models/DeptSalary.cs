using System;
using System.Collections.Generic;

namespace web_api_sp.Models
{
    public partial class DeptSalary
    {
        public int? DepartmentUserCount { get; set; }
        public decimal? MaximumSalary { get; set; }
        public decimal? MinimumSalary { get; set; }
    }
}
