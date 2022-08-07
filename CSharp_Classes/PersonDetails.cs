namespace CSharp_Classes
{
    internal class PersonDetails
    {
        public string firstName = "Joshua";
        public string lastName = "Pautanes";
        public string address = "Quezon City";
        public int age = 22;

        // void if theres no to return
        public static string FullDetail(string firstName, string lastName, string address, int age)
        {
            string Details = $"Fullname: {firstName} {lastName} \nAddress: {address} \nAge:{age}";
            return Details;
        }
    }
}
