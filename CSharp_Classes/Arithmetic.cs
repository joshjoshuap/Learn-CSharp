using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Classes
{
  class Arithmetic
    {
        // declare public static if want to access to other class
        // declare private static to prevent access to other class
        public static int add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
