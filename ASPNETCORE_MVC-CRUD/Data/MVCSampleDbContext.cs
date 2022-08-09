using ASPNETCORE_CRUD.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE_CRUD.Data
{
    public class MVCSampleDbContext : DbContext
    {
        public MVCSampleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
