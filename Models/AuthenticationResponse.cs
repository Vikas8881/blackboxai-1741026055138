namespace greedustEcommerce.Models
{
    public class AuthenticationResponse
    {
        public string? Token { get; set; }
        public bool RequiresMfa { get; set; }
        public string? MfaType { get; set; } // Email, Authenticator
        public User? User { get; set; }
    }
}
