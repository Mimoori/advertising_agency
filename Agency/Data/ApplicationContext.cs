using Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Article> article { get; set; }
    }
}
