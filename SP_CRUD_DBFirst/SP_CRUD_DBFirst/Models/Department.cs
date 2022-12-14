using System;
using System.Collections.Generic;

namespace SP_CRUD_DBFirst.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<UsersDetail> UsersDetails { get; } = new List<UsersDetail>();
}
