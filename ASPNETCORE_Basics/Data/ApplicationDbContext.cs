using ASPNETCORE_Basics.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE_Basics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
