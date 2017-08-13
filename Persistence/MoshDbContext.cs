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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=mydb.c8jire4gyzlv.eu-central-1.rds.amazonaws.com; database=moshwebcourse;user=awsuser;password=Troloby1!");

        public DbSet<Make> Makes { get; set; }
    }
}
