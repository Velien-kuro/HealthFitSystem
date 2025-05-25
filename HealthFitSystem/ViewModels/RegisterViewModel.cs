using System.ComponentModel.DataAnnotations;

namespace HealthFitSystem.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password must be at least {2} characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]    
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Choose the Gender")]
        public string Gender { get; set; }

    }
}
