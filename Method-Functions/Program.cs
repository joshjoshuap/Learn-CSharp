namespace CSharp_Method_Functions
{
    class Program
    {
        static string globalVariable = "I am a Global Variable !!!";
        static void Main(string[] args)
        {
            Console.WriteLine(globalVariable); // I am a Global Variable
            SimpleMethod(); // This is Simple Method and I am a Global Variable
            FullName("Joshua Pautanes"); // Hello Joshua Pautanes
            Console.WriteLine(Addition(1, 3)); // 4

            string personInfo = PersonDetails("Joshua", "Pautanes", "Quezon City");
            Console.WriteLine(personInfo); // Hi Joshua Pautanes from Quezon City

            static void SimpleMethod()
            {
                Console.WriteLine("This is a simple Method and " + globalVariable);
            }

            static void FullName(string name)
            {
                Console.WriteLine("Hello, " + name);
            }

            static string PersonDetails(string firstName, string lastName, string address)
            {
                string personInfo = "Hi " + firstName + " " + lastName + " " + "from " + address;
                return personInfo;
            }

            static int Addition(int num1, int num2)
            {
                return num1 + num2;
            }
        }
    }
}