namespace CSharp_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            int i = 1;
            while (i < 4)
            {
                Console.WriteLine("Loop " + i);
                i++;
            }
            /* 
             Loop 1
             Loop 2
             Loop 3
             */

            // Do While
            int num1 = 0;
            do
            {
                Console.WriteLine("Num:" + num1);
                num1++;
            } while (num1 < 5);
            /* 
            Num: 1
            Num: 2
            Num: 3
            Num: 4
             */

            // Do While User Input
            int userAge;
            do
            {
                Console.WriteLine("Only Above is Allowed");
                Console.WriteLine("Enter your age");
                userAge = Convert.ToInt32(Console.ReadLine());
            } while (userAge <= 18);
            Console.WriteLine("You are Allowed");
            /* 
             - User input 21
            You are allowed
             */

            // Do While Array
            int[] nums = { 1, 2, 3, 4, 5 };
            int index = 0;
            do
            {
                Console.WriteLine("Number " + nums[index]);
                index++;
            } while (index < nums.Length);
            /* 
            Number 1
            Number 2
            Number 3
            Number 4
            Number 5
             */

            // For Loop - One DImensional Array
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("No: " + a);
            }
            /* 
            No: 0
            No: 1
            No: 2
             */

            // For Loop - One Dimensional Array
            string[] names = { "Jose", "Maria", "Juan" };
            for (int name = 0; name < names.Length; name++)
            {
                Console.WriteLine("Hello, " + names[name]);
            }
            /* 
            Jose
            Maria
            Juan
             */

            // For Loop Find  One DImensional Array
            string[] person = { "Juan", "Maria", "Jose", "", "Emilio" };
            for (int findNull = 0; findNull < person.Length; findNull++)
            {
                if (person[findNull] == "")
                {
                    Console.WriteLine("Theres a null in array");
                }
            }
            /* Theres a null in array */

            // For Loop - Two Dimensional Array
            string[,] country = {
            {"Manila", "Philippines"},
            {"Seoul", "Korea"},
            {"Tokyo", "Japan"}
            };

            for (int row = 0; row < country.GetLength(0); row++)
            {
                Console.WriteLine($"Country: {country[row, 0]}, {country[row, 1]}");
            }
            /* 
            Manila, Philippines
            Seoul, Korea
            Tokyo, Japan
             */

            for (int rows = 0; rows < country.GetLength(0); rows++)
            {
                for (int cols = 0; cols < country.GetLength(1); cols++)
                {
                    Console.WriteLine(country[rows, cols]);
                }
            }
            /* 
            Manila
            Phillipines
            Seoul
            Korea
            Tojyo
            Japan
             */

            // For Each - One Dimensional Array
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            /*
            Apple
            Banana
            Orange
             */

            // For Each conditonal
            string[] password = { "123", "admin", "password123", "wow123", "abcd" };
            foreach (string breakPassword in password)
            {
                if (!breakPassword.Equals("wow123"))
                {
                    Console.WriteLine("Breaking Password Failed Trying Again...");
                }
                else if (breakPassword.Equals("wow123"))
                {
                    Console.WriteLine("You Break the password");
                    break;
                }
            }
            /* 
            Breaking Password Failed Trying Again...
            Breaking Password Failed Trying Again...
            Breaking Password Failed Trying Again...
            You Break the password
             */

            // For Each - Two Dimensional Array
            string[,] cars = {
            {"Vios", "Innova"},
            {"Xpander", "Montero"},
            {"Wigo", "Brio"}
            };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            /* 
            Vios
            Innova
            Xpander
            Montero
            Wigo
            Brio
             */
        }
    }
}