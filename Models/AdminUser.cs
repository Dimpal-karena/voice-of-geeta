
using Microsoft.AspNetCore.Identity;

namespace The_voice_of_geeta.Models
{
    public class AdminUser : IdentityUser
    {
        public string FullName { get; set; }
        public string ProfileImage { get; set; }
    }
}
