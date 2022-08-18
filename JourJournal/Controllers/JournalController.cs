using JourJournal.Data;
using JourJournal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace JourJournal.Controllers
{
    public class JournalController : Controller
    {
        private readonly JourJournalDbContext jourJournalDbContext;
        public JournalController(JourJournalDbContext jourJournalDbContext)
        {
            this.jourJournalDbContext = jourJournalDbContext;
        }

        // Display Journal List
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var journal = await jourJournalDbContext.JournalList.ToListAsync();
            return View(journal);
        }

        // Display Add Form
        [HttpGet]
        public IActionResult AddJournal()
        {
            return View();
        }

        // Adding Journal
        [HttpPost]
        public async Task<IActionResult> AddJournal(AddJournalViewModel addJournal)
        {
            var journal = new Journal()
            {
                Id = Guid.NewGuid(),
                title = addJournal.title,
                description = addJournal.description
            };
            await jourJournalDbContext.JournalList.AddAsync(journal);
            await jourJournalDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Updating Journal - Display Form
        [HttpGet]
        public async Task<IActionResult> UpdateJournal(Guid Id)
        {
            var journal = await jourJournalDbContext.JournalList.FirstOrDefaultAsync(x => x.Id == Id);
            if (journal != null)
            {
                var updateModel = new UpdateJournalViewModel()
                {
                    Id = journal.Id,
                    title = journal.title,
                    description = journal.description
                };
                return await Task.Run(() => View("UpdateJournal", updateModel));
            }
            return RedirectToAction("Index");
        }

        // Updating Journal Data
        [HttpPost]
        public async Task<IActionResult> UpdateJournal(UpdateJournalViewModel model)
        {
            var journal = await jourJournalDbContext.JournalList.FindAsync(model.Id);
            if (journal != null)
            {
                journal.title = model.title;
                journal.description = model.description;

                await jourJournalDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // Deleting Journal
        [HttpPost]
        public async Task<IActionResult> DeleteJournal(UpdateJournalViewModel model)
        {
            var journal = await jourJournalDbContext.JournalList.FindAsync(model.Id);
            if (journal != null)
            {
                jourJournalDbContext.JournalList.Remove(journal);
                await jourJournalDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
