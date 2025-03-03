using Microsoft.AspNetCore.Identity;

namespace greedustEcommerce.Models
{
    public class User : IdentityUser
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLogin { get; set; }
        public string? SocialLoginProvider { get; set; } // Google, Facebook, Apple
        public string? SocialLoginId { get; set; }
        public string? MfaSecret { get; set; }
        public bool MfaEnabled { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }

    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }

    public class UserRole : IdentityUserRole<string>
    {
        public virtual User? User { get; set; }
        public virtual ApplicationRole? Role { get; set; }
    }
}
