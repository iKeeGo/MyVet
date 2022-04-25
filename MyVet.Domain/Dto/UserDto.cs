using System.ComponentModel.DataAnnotations;

namespace MyVet.Domain.Dto
{
    public class UserDto
    {

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(200)]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirm password")]
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        public string ConfirmPassword { get; set; }


    }
}