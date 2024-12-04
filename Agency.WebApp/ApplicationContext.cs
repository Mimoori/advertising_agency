using Agency.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Article> article { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Service> service { get; set; }

    }
}
