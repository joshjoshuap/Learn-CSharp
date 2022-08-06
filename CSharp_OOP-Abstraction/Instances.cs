using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Abstraction
{
    class Instances
    {
    }

    interface School
    {
        void displayInfo();
    }

    class Student : School
    {
        public void displayInfo()
        {

        }

    }

    class Teacher : School
    {
        public void displayInfo()
        {

        }

    }
}
