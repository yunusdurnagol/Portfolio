using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Portfolio.Persistence.Core.DataLayer;
using Portfolio.Persistence.Core.Models;

namespace Portfolio.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}