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
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Melissa's
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Profile>().ToTable("Profile");
            modelBuilder.Entity<Message>().ToTable("Message");
        }
    }
}