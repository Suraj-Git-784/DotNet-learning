using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginFormAspCore.Models;

public partial class UserTable
{
    public int Id { get; set; }

    [Required]
    [DisplayName("Name")]
    public string UserName { get; set; } = null!;

    [Required]
    [DisplayName("Email")]
    public string UserEmail { get; set; } = null!;

    [Required]
    [DisplayName("Gender")]
    public string? UserGender { get; set; }

    [Required]
    [DisplayName("Password")]
    [DataType(DataType.Password)]
    public string UserPassword { get; set; } = null!;

    [Required]
    [DisplayName("Age")]
    public int? UserAge { get; set; }
}
