using Microsoft.AspNetCore.Mvc;
using Basic_Fundamentals.Data;
using System.Collections.Generic;
using Basic_Fundamentals.Models;

namespace Basic_Fundamentals.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;

        }
        public IActionResult Category()
        {
            IEnumerable<Category> objlist = _db.Category;
            return View(objlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Category");
        }
    }
}
