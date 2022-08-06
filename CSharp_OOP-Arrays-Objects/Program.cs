using System;

namespace CSharp_OOP_Arrays_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[2];
            studentList[0] = new Student("Jose", "Rizal", "Manila", "Medicine", "Senior");
            studentList[1] = new Student("Emilio", "Aguinaldo", "Cavite", "Law", "Elite");

           foreach (Student student in studentList)
            {
                student.displayInfo();
            }
            /*
            -----
            Name: Jose Rizal
            Address Manila
            Course: Medicine
            Level: Senior
            -----
            Name: Emilio Aguinaldo
            Address Cavite
            Course: Law
            Level: Elite
            */
        }
    }
    class Student
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string address { get; set; }
        string course { get; set; }
        string level { get; set; }

        public Student(string firstName, string lastName, string address, string course, string level)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.course = course;
            this.level = level;
        }

        public void displayInfo()
        {
            Console.WriteLine("-----");
            Console.WriteLine($"Name: {firstName} {lastName} \nAddress {address} \nCourse: {course} \nLevel: {level}");
        }

    }
}
