using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;

    public int? Age { get; set; }

    public string EmployeeEmail { get; set; } = null!;

    public string EmployeeGender { get; set; } = null!;
}
