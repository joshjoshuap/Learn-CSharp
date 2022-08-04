using System;

namespace CSharp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 6;

            int totalAdd = Arithmetic.add(number1, number2); // Pass the value to arithmetic class then pass again to add() method
            int totalSubtract = Arithmetic.subtract(number1, number2);

            Console.WriteLine(totalAdd); // 11
            Console.WriteLine(totalSubtract); // -1

            Accounts.password = "000"; // error cant change the password only readonly
        }
    }
}
