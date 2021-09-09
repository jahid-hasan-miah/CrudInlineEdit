using InlineEditingJobTask.Models;
using Microsoft.EntityFrameworkCore;

namespace InlineEditingJobTask.Context
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
