using System.ComponentModel.DataAnnotations;

namespace WebAppDotNet.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "asdasd")]
        public string Name { get; set; }
        [Display(Name = "Age")]
        //Enum = Collection of constants
        [Required(ErrorMessage = "Age is required")]
        public int? Age { get; set; }
        //public Gender Gender { get; set; }
        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is requried")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*[0-9]).{8,}$")]
        public required string Password { get; set; }
        [Compare("Password", ErrorMessage ="Password not matched")]
        [Required(ErrorMessage = "Confirm Password is requried")]
        [Display(Name = "Confirm Password")]
        public required string ConfirmPassword { get; set; }
        [Display(Name = "Website Url")]
        [Required(ErrorMessage = "Website Url is requried")]
        public required string WebsiteUrl { get; set; }
        //public int Salary { get; set; }
        //public required string Description { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }

    //public class EmployeeModel
    //{
    //    public required string Name { get; set; }
    //    public int Age { get; set; }
    //}
}
