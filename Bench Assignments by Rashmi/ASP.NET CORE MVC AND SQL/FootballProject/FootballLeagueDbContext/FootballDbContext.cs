using FootballProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballProject.FootballLeagueDbContext
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext():base()
        {

        }
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<FootBallLeague> FootBallLeagues { get; set; }
    }
}
