using BayouTech.Domain;
using Microsoft.EntityFrameworkCore;

namespace BayouTech.Persistence
{
    public class BayouTechDbContext: DbContext
    {
        public BayouTechDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }


    }
}
