namespace CSharp_OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.firstName = "Jose";
            p1.lastName = "Rizal";
            p1.age = 100;
            p1.sex = 'M';

            Person p2 = new Person();
            p2.firstName = "Emilio";
            p2.lastName = "Aguinaldo";
            p2.age = 99;
            p2.sex = 'M';

            Person p3 = new Person();
            p2.firstName = "Andres";
            p2.lastName = "Bonifacio";
            p2.age = 101;
            p2.sex = 'M';

            Console.WriteLine(p1.firstName + " " + p1.lastName); // Jose Rizal

        }
    }
}