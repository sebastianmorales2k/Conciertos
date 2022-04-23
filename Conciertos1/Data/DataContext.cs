using Conciertos1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Conciertos1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Entrance> Entrances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Entrance>().HasIndex(c => c.Id).IsUnique();
        }
    }

}
