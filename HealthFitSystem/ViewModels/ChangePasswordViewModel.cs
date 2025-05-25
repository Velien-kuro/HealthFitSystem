using System.ComponentModel.DataAnnotations;

namespace HealthFitSystem.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password must be at least {2} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]

        [Compare("ComfirmNewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public String ComfirmNewPassword { get; set; }
    }
}
