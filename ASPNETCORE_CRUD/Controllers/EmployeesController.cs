using ASPNETCORE_CRUD.Data;
using ASPNETCORE_CRUD.Models;
using ASPNETCORE_CRUD.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE_CRUD.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCSampleDbContext mvcSampleDbContext;
        public EmployeesController(MVCSampleDbContext mvcSampleDbContext)
        {
            this.mvcSampleDbContext = mvcSampleDbContext;
        }

        // Displaying Data
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await mvcSampleDbContext.Employees.ToListAsync();
            return View(employees);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View(); // Add.cshtml
        }

        // Adding Data
        [HttpPost]
        public async  Task<IActionResult> Add(AddEmployeeViewModel addEmployee)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployee.Name,
                Address = addEmployee.Address,
                Position = addEmployee.Position
            };

            await mvcSampleDbContext.Employees.AddAsync(employee);
            await mvcSampleDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Updating Data
        [HttpGet]
        public IActionResult View(Guid id)
        {
            var employee = mvcSampleDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            
            return View();
        }
    }
}
