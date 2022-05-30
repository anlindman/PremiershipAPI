using Microsoft.EntityFrameworkCore;

namespace PremiershipAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
