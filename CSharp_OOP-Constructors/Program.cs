namespace CSharp_OOP_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passing Value
            Student s1 = new Student("Juan", 10, 20, 30);
            /* 
            Name: Juan
            Math: 10
            English: 20
            Science: 30
             */
            Student s2 = new Student("Jose", 100, 99, 100);

            // Pass and Accessing Value
            Person p1 = new Person("Jose", "Rizal");
            // passing the value and retrieve
            Console.WriteLine($"Bayani; {p1.firstName} {p1.lastName}"); // Jose Rizal

            // Using Object Method
            Accounts a1 = new Accounts("admin", "admin123");
            // accessing the specific object method
            a1.displayAccount();
            /* 
           Username: admin 
           Password: admin123
           */
            a1.displayUsername(); // Username: admin
        }
    }
}