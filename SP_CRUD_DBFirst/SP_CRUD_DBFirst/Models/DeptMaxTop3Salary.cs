using System;
using System.Collections.Generic;

namespace SP_CRUD_DBFirst.Models;

public partial class DeptMaxTop3Salary
{
    public decimal Salary { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
