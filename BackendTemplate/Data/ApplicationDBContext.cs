using Microsoft.EntityFrameworkCore;
namespace BackendTemplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Post> Posts { get; set; }
    }
}