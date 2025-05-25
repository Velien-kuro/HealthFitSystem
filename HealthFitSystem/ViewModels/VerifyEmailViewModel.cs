using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HealthFitSystem.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
