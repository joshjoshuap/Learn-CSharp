using System;

namespace CSharp_OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(000, "Jose", "Rizal", "Senior teacher", "Programming");
            teacher1.displayInfo();
            Console.WriteLine("Subject: " + teacher1.handledSubject);
            /*
            ID no: 0
            Firstname: Jose
            Lastname: Rizal
            Position; Senior Teacher
            Subject Teach: Programming
             */

            Student student1 = new Student(122, "Joshua", "Pautanes", "Alumni", 85, 90, 100);
            student1.displayInfo();
            student1.averageGrade();
            /* 
            ID No: 122
            Firstname: Joshua
            Lastname: Pautanes
            Position: Alumni
            Average: 91
             */

        }
    }

    // Simple Inheritance
    class SchoolData
    {
        public int schooID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string schoolPosition { get; set; }

        // SchoolData constructor
        public SchoolData(int schoolD, string firstName, string lastName, string schoolPosition)
        {
            this.schooID = schoolD;
            this.firstName = firstName;
            this.lastName = lastName;
            this.schoolPosition = schoolPosition;
        }

        public void displayInfo()
        {
            Console.WriteLine("\n -- User Info --");
            Console.WriteLine($"ID no: {schooID} \nFirstname: {firstName} \nLastname {lastName} \nPosition: {schoolPosition}");
        }

    }

    class Teacher : SchoolData // Inherit the Value and method  of school
    {
        public string handledSubject { get; set; }
        // Teacher Constructor
        public Teacher (int schoolD, string firstName, string lastName, string schoolPosition, string handledSubject) : base(schoolD, firstName, lastName, schoolPosition) // inherit the base value must be the same to SchoolData constructor
        {
            this.handledSubject = handledSubject;
        }
    }

    class Student : SchoolData
    {
        public int gradeQ1 { get; set; } // get value and return
        public int gradeQ2 { get; set; }
        public int gradeQ3 { get; set; }

        // Student Constructor with Additional parameter
        public Student (int schoolD, string firstName, string lastName, string schoolPosition, int gradeQ1, int gradeQ2, int gradeQ3) : base(schoolD, firstName, lastName, schoolPosition)
        {
            this.gradeQ1 = gradeQ1;
            this.gradeQ2 = gradeQ2;
            this.gradeQ3 = gradeQ3;
        }
 
        public void averageGrade()
        {
            Console.WriteLine($"Average: {(gradeQ1 + gradeQ2 + gradeQ3) / 3}");
        }
    }

}
