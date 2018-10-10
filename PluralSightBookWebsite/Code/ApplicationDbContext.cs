using Microsoft.AspNet.Identity.EntityFramework;
using PluralSightBookWebsite.Models;
using System.Data.Entity;

namespace PluralSightBookWebsite.Code
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext()
            : base("ApplicationServices")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>()
                .HasRequired(n => n.User)
                .WithMany(u => u.Friends)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Friends)
                .WithRequired(f => f.User)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Friend> Friends { get; set; }
    }
}