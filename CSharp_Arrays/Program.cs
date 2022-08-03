using System;

namespace CSharp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Array
            string[] name = { "Jose", "Rizal" };
            Console.WriteLine($"{name[0]} {name[1]}"); // Jose Rizal

            // Setting Size and Value
            int[] numbers = new int[2];
            numbers[0] = 1;
            numbers[1] = 5;
            Console.WriteLine($"Total: {numbers[0] + numbers[1]}"); // Total: 6

            // User input to Array
            string[] pet = new string[2];
            Console.WriteLine("Enter a two pet");
            pet[0] = Console.ReadLine(); // get user input store to specific index
            pet[1] = Console.ReadLine();
            Console.WriteLine($"The two pet are {pet[0]} and {pet[1]}"); // The two pet are dog and cat
        }
    }
}
