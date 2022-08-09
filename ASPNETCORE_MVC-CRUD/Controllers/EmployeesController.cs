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

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployee)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployee.Name,
                Address = addEmployee.Address,
                Position = addEmployee.Position
            };

            await mvcSampleDbContext.Employees.AddAsync(employee);
            await mvcSampleDbContext.SaveChangesAsync(); // Save To Database
            return RedirectToAction("Index");
        }

        // Updating Data - Displaying in Form
        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var employee = await mvcSampleDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee != null)
            {

                var viewModel = new UpdateEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Address = employee.Address,
                    Position = employee.Position
                };
                return await Task.Run(() => View("View", viewModel)); // return view of form
            }

            return RedirectToAction("Index");
        }

        // Updating Data - Change Data
        [HttpPost]
        public async Task<IActionResult> View(UpdateEmployeeViewModel model)
        {
            var employee = await mvcSampleDbContext.Employees.FindAsync(model.Id);
            if (employee != null)
            {
                employee.Name = model.Name;
                employee.Address = model.Address;
                employee.Position = model.Position;

                mvcSampleDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // Deleting Data
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel model)
        {
            var employee = await mvcSampleDbContext.Employees.FindAsync(model.Id);
            if (employee != null)
            {
                mvcSampleDbContext.Employees.Remove(employee);
                await mvcSampleDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
