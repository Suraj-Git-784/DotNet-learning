using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginFormAspCore.Models;

public partial class UserTable
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    [DisplayName("Email")]
    public string UserEmail { get; set; } = null!;

    public string? UserGender { get; set; }
    
    [DataType(DataType.Password)]
    public string UserPassword { get; set; } = null!;

    public int? UserAge { get; set; }
}
