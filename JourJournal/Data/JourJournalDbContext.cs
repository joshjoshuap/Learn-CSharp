using JourJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace JourJournal.Data
{
    public class JourJournalDbContext : DbContext
    {
        public DbSet<Journal> JournalList { get; set; }
        public JourJournalDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
