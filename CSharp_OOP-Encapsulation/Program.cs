namespace CSharp_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("admin", "123", "Manila");
            Console.WriteLine($"Username: {ac.UserName} \nPassword: {ac.UserPassword} \nLocation: {ac.userAddress}");
        }
    }
}