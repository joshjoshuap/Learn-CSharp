﻿namespace AspNetCore_MVC_CRUD2.Models
{
    public class UpdateStudentViewModel
    {
        public Guid Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string section { get; set; }
        public string level { get; set; }
    }
}
