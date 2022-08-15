using AspNetCore_MVC_CRUD2.Data;
using AspNetCore_MVC_CRUD2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_MVC_CRUD2.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly SimpleCRUD2DbContext simpleCRUD2DbContext;
        public StudentInfoController(SimpleCRUD2DbContext simpleCRUD2DbContext)
        {
            this.simpleCRUD2DbContext = simpleCRUD2DbContext;
        }


        // Display Index Student List
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var student = await simpleCRUD2DbContext.StudentInfos.ToListAsync();
            return View(student); // pass the list of student to index.cshtml
        }

        // Display Add Form
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Add Student
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel addStudent)
        {
            var student = new StudentInfo()
            {
                Id = Guid.NewGuid(),
                firstName = addStudent.firstName,
                lastName = addStudent.lastName,
                section = addStudent.section,
                level = addStudent.level
            };
            await simpleCRUD2DbContext.StudentInfos.AddAsync(student);
            await simpleCRUD2DbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // Display Update Form
        [HttpGet]
        public async Task<IActionResult> Update(Guid Id)
        {
            var student = await simpleCRUD2DbContext.StudentInfos.FirstOrDefaultAsync(x => x.Id == Id);
            if (student != null)
            {
                var updateModel = new UpdateStudentViewModel()
                {
                    Id = student.Id,
                    firstName = student.firstName,
                    lastName = student.lastName,
                    section = student.section,
                    level = student.level
                };

                return await Task.Run(() => View("Update", updateModel));
            }
            return RedirectToAction("Index");
        }

        // Updating Student
        [HttpPost]
        public async Task<IActionResult> Update(UpdateStudentViewModel model)
        {
            var student = await simpleCRUD2DbContext.StudentInfos.FindAsync(model.Id);
            if (student != null)
            {
                student.firstName = model.firstName;
                student.lastName = model.lastName;
                student.section = model.section;
                student.level = model.level;

                await simpleCRUD2DbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // Deleting Student
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudentViewModel model)
        {
            var student = await simpleCRUD2DbContext.StudentInfos.FindAsync(model.Id);
            if (student != null)
            {
                simpleCRUD2DbContext.StudentInfos.Remove(student);
                await simpleCRUD2DbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
