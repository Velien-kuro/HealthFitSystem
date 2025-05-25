using System.ComponentModel.DataAnnotations;
namespace HealthFitSystem.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]

        [EmailAddress]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
