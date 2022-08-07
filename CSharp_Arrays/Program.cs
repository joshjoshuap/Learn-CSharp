namespace CSharp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // One Dimensional Array
            string[] name = { "Jose", "Rizal" };
            Console.WriteLine($"{name[0]} {name[1]}"); // Jose Rizal

            // Setting Size and Value - One Dimensional Array
            int[] numbers = new int[2];
            numbers[0] = 1;
            numbers[1] = 5;
            Console.WriteLine($"Total: {numbers[0] + numbers[1]}"); // Total: 6

            // User input - One Dimensional Array
            string[] pet = new string[2];
            Console.WriteLine("Enter a two pet");
            pet[0] = Console.ReadLine(); // get user input store to specific index
            pet[1] = Console.ReadLine();
            Console.WriteLine($"The two pet are {pet[0]} and {pet[1]}"); // The two pet are dog and cat

            // Two Dimesional Array
            string[,] heroesName = {
                {"Jose", "Rizal"}, // 0 - 0 ,1
                {"Emilio", "Aguinaldo"},  // 1 - 0, 1
                {"Andres", "Bonifacio"}// 2 - 0, 1
            };
            Console.WriteLine("The National Hero is " + heroesName[0, 0] + " " + heroesName[0, 1]); // The National Hero is Jose Rizal

            // Setting Size and Value - Two Dimensional Array
            string[,] address = new string[3, 2]; // rows, cols
            address[0, 0] = "Novaliches";
            address[0, 1] = "Quezon CIty";

            address[1, 0] = "Monumento";
            address[1, 1] = "Caloocan";

            address[2, 0] = "Tondo";
            address[2, 1] = "Manila";

            // This will create two dimensional array
            /* 
            {
            {Novaliches, Quezon City}
            {Monumento, Caloocan}
            {Tondo, Manila}
            }
             */
            Console.WriteLine($"I am from {address[1, 0]},{address[2, 1]}"); // I am from Monumento,Manila

            // For Loop -  One Dimensional Array
            string[] names = { "Jose", "Maria", "Juan" };
            for (int personName = 0; personName < names.Length; personName++)
            {
                Console.WriteLine("Hello, " + names[personName]);
            }
            /* 
            Jose
            Maria
            Juan
             */

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

            // For Loop Find  - One Dimensional Array
            string[] person = { "Juan", "Maria", "Jose", "", "Emilio" };
            for (int findNull = 0; findNull < person.Length; findNull++)
            {
                if (person[findNull] == "")
                {
                    Console.WriteLine("Theres a null in array");
                }
            }
            /* Theres a null in array */

            // For Each - One DImensional Array
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

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
        }
    }
}