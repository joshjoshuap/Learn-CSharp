using AspNetCore_MVC_CRUD2.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_MVC_CRUD2.Data
{
    public class SimpleCRUD2DbContext : DbContext
    {
        public SimpleCRUD2DbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentInfo> StudentInfos { get; set; }
    }
}
