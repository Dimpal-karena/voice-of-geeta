using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace The_voice_of_geeta.wwwroot.Data
{
    public class ApplicationDbContext : IdentityDbContext<AdminUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Shloka> Shlokas { get; set; }
    }
}
