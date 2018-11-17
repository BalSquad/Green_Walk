using GreenWalkModel;
using Microsoft.EntityFrameworkCore;

namespace GreenWalkApi.Models
{
    public class GreenWalkContext : DbContext
    {
        public GreenWalkContext(DbContextOptions<GreenWalkContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Success>()
                .HasMany(s => s.Users);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Successes);
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Success> Successes { get; set; }

    }
}
