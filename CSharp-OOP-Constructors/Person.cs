using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Constructors
{
    class Person // class
    {
        public string firstName;
        public string lastName;
        public Person(string firstName, string lastName) // method
        {
            this.firstName = firstName; // pass the value to public string firstName
            this.lastName = lastName;
        }
    }
}
