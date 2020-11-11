using aspnetcore_n_tier.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_n_tier.DAL.DataContext
{
    public class AspNetCoreNTierDbContext: DbContext
    {
        public AspNetCoreNTierDbContext(DbContextOptions<AspNetCoreNTierDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User
                 {
                     UserId = 1,
                     Username = "username",
                     Name = "username",
                     Surname = "username",
                 }
             );
        }
    }
}
