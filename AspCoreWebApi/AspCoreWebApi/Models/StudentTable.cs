using System;
using System.Collections.Generic;

namespace AspCoreWebApi.Models;

public partial class StudentTable
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public int Age { get; set; }

    public int Standard { get; set; }

    public string ParentName { get; set; } = null!;
}
