using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Constructors
{
    class Student
    {
        public string name;
        public int mathGrade;
        public int englishGrade;
        public int scienceGrade;

        public Student(string name, int mathGrade, int englishGrade, int scienceGrade)
        {
            this.name = name; // pass the value to public string name
            this.mathGrade = mathGrade;
            this.englishGrade = englishGrade;
            this.scienceGrade = scienceGrade;

            Console.WriteLine("--- Student Grade Inputted ---");
            Console.WriteLine($"Name: {name} \nMath: {mathGrade} \nEnglish: {englishGrade} \nScience {scienceGrade}");
        }
    }
}
