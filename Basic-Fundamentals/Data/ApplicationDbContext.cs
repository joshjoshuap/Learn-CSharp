using Basic_Fundamentals.Models;
using Microsoft.EntityFrameworkCore;

namespace Basic_Fundamentals.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
