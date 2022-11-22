using Microsoft.EntityFrameworkCore;

namespace CoreStartApp.Models
{
    public class CoreStartAppContext : DbContext
    {
        public CoreStartAppContext(DbContextOptions<CoreStartAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("UserInfos");
        }
    }
}
