using System;

namespace CSharp_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF
            Boolean isTrue = true;
            if (isTrue)
            {
                Console.WriteLine("True");
            }

            // IF ELSE
            int age = 18;
            if (age < 18)
            {
                Console.WriteLine("Minor");
            }
            else
            {
                Console.WriteLine("Adult");
            }

            // IF ELSE IF
            int userAge = 5;
            if (userAge <= 6)
            {
                Console.WriteLine("Hello Baby");
            }
            else if (userAge <= 6)
            {
                Console.WriteLine("Hey Kid");
            }
            else if (userAge <= 12)
            {
                Console.WriteLine("What's up Teen");
            }
            else if (userAge <= 60)
            {
                Console.WriteLine("How are you");
            }
            else
            {
                Console.WriteLine("My Respect");   
            }

            // Nested IF ELSE
            string personName, personCountry;
            int personAge;

            Console.WriteLine("Enter Your name");
            personName = Console.ReadLine();

            if(personName != "")
            {
                Console.WriteLine($"Hello {personName}");
                Console.WriteLine("Enter your Age");
                personAge = Convert.ToInt32(Console.ReadLine());

                if(personAge >= 18)
                {
                    Console.WriteLine("Hi You are allowed");
                    Console.WriteLine("Enter your country");
                    personCountry = Console.ReadLine();

                    if(personCountry == "Philippines")
                    {
                        Console.WriteLine("Mabuhay");
                    } else
                    {
                        Console.WriteLine("Sorry Only from Phiilippines can Access");
                    }

                } else
                {
                    Console.WriteLine("Sorry Minor Not Allowed");
                }

            } else
            {
                Console.WriteLine("Please Enter a Name");
            }

            // Logical Operator
            string username = "admin", password = "admin1"; // Password Incorrect

            if (username == "admin" && password == "admin123") Console.WriteLine("Logged IN");
            if (username != "admin" && password == "admin123") Console.WriteLine("Username Incorrect");
            if (username == "admin" && password != "admin123") Console.WriteLine("Password Incorrect");
            if (username != "admin" && password != "admin123") Console.WriteLine("Both Incorrect");

            // One Line Ternary Operator
            int grade = 80;
            string result = (grade >= 76) ? "Passed" : "Failed" ;
            Console.WriteLine(result); // Passed

            // Switch Case
            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a day");
                    break;
            }
        }
    }
}
