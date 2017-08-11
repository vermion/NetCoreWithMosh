using Microsoft.EntityFrameworkCore;
using NetCoreWithMosh.Models;

namespace NetCoreWithMosh.Persistence
{
    public class MoshDbContext : DbContext
    {

        public MoshDbContext(DbContextOptions<MoshDbContext> options) : base(options)
        {
            // System.Configuration.ConfigurationManager
        }

        public DbSet<Make> Makes { get; set; }


    }
}
