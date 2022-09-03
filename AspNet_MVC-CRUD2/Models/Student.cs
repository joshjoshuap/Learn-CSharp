using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNet_MVC_CRUD2.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }
    }

    public class ASPNetMVCCRUD2 : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}