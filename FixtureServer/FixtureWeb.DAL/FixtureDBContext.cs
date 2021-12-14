using Microsoft.EntityFrameworkCore;

namespace FixtureWeb.DAL
{
    public class FixtureDBContext : DbContext
    {
        public FixtureDBContext(DbContextOptions<FixtureDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Models.Fixture> Fixtures { get; set; }

        public DbSet<Models.Result> Results { get; set; }
    }
}
