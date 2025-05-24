using Microsoft.AspNetCore.Identity;

namespace HealthFitSystem.Models
{
    public class Users : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
