namespace CSharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basics
            Console.WriteLine("Hello World!"); // Hello World
            Console.Write("Hello \nWorld");
            /* 
            Hello
            World
             */

            // Data Types
            char firstLetter = 'J';
            string firstName = "Joshua";
            string lastname = "Pautanes";
            int age = 22;
            Boolean isHandsome = true;

            Console.WriteLine("\nFull Name: " + firstName + " " + lastname); // Fullname: Joshua Pautanes
            Console.Write($"Firstname: {firstName} \nLastname: {lastname} \nAge: {age} \nFirstLetter {firstLetter} \nHandsome: {isHandsome}");
            /* 
            Firstname: Joshua
            Lastname: Pautanes
            Age: 22
            First Letter: J
            Hansome: true
             */

            // Data Type Conversion
            string strNumber1 = "1", strNumber2 = "2";
            int convertedNumber1, convertedNumber2;

            convertedNumber1 = Convert.ToInt32(strNumber1);
            convertedNumber2 = Convert.ToInt32(strNumber2);
            Console.WriteLine($"Total: {convertedNumber1 + convertedNumber2}"); // Total: 3

            // Arithmetic
            int num1, num2, totalAdd, totalSub, totalMultiply, totalDivide, totalModulo;
            double totalDecimal;
            num1 = 2;
            num2 = 5;
            float decimalNum1 = 6.9f;
            double decimalNum2 = 1.123456d;
            totalAdd = num1 + num2;
            totalSub = num1 - num2;
            totalMultiply = num1 * num2;
            totalDivide = num1 / num2;
            totalModulo = num1 % num2;
            totalDecimal = decimalNum1 + decimalNum2;

            Console.Write($"First Number: {num1} \nSecond Number: {num2}  \nAddition: {totalAdd} \nSubtraction: {totalSub} \nMultiplication: {totalMultiply} \nDivision: {totalDivide} \nModulo: {totalModulo} \nDecimal: {totalDecimal}");
            /* 
            First Number: 2
            Second Number: 5
            Addition: 7
            Subtraction: -3
            Multiplication: -3
            Division: 0
             */

            // Assignment Arithmetic
            int count = 1, counter = 1;
            count += counter;
            Console.WriteLine(count); // 2

            // Get User Input
            string fullName, address, course;
            char key;

            Console.WriteLine("\nEnter fullname");
            fullName = Console.ReadLine(); // read user input

            Console.WriteLine("Enter address");
            address = Console.ReadLine();

            Console.WriteLine("Enter course");
            course = Console.ReadLine();

            Console.WriteLine("Enter Average Grade");

            Console.Write($"You fullname is {fullName} from {address} and course is {course} \n");  // Your fullname is Joshua from Quezon CIty and course is BSIT

            Console.WriteLine("Press any key");
            key = Console.ReadKey().KeyChar; // getting user key pressed
            Console.WriteLine("\nYou pressed letter: " + key); // You pressed Letter a

        }
    }
}