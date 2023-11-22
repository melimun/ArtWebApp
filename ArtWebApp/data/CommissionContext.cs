using Microsoft.EntityFrameworkCore;
using ArtWebApp.Models;
//Matthew Goehner
namespace ArtWebApp.Data
{
    public class CommissionContext : DbContext
    {
        public CommissionContext (DbContextOptions<CommissionContext> options)
            : base(options)
        {
        }

        public DbSet<Commission> Commissions{ get; set; }
        public DbSet<OrderedCommission> OrderedCommissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commission>().ToTable("Commission");
            modelBuilder.Entity<OrderedCommission>().ToTable("orderedCommissions");
        }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Filename=commissions.db");
        }
    }
}