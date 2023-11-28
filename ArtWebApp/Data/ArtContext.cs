using Microsoft.EntityFrameworkCore;
using ArtWebApp.Models;

namespace ArtWebApp.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext (DbContextOptions<ArtContext> options)
            : base(options)
        {
        }

        //Melissa's 
        public DbSet<User> Users{ get; set; }
        public DbSet<Profile> Profiles { get; set; }
        // public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Melissa's
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Profile>().ToTable("Profile");
            // modelBuilder.Entity<Message>().ToTable("Message");

            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)        // User has one Profile
                .WithOne(p => p.User)          // Profile has one User
                .HasForeignKey<Profile>(p => p.ProfileID)  // Use ProfileID as foreign key
                .OnDelete(DeleteBehavior.Cascade); // If a User is deleted, delete the associated Profile

        }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Filename=CU.db");
        }
    }
}