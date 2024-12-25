using Agency.WebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agency.WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Surname)
                .HasMaxLength(250);
            
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Patronymic)
                .IsRequired(false)
                .HasMaxLength(250);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Organization)
                .HasMaxLength(250);

        }

        public DbSet<Article> articles { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Service> service { get; set; }
        public DbSet<Worker> workers { get; set; } = default!;
    }
}
