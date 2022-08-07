namespace CSharp_OOP_Encapsulation
{
    class Account
    {
        private string username;
        private string password;

        public string UserName
        {
            get { return username; }  // return inputted value
            set { username = value; } // setting inputted value
        }

        public string UserPassword
        {
            get { return password; }
            set
            {
                if (value != " ")
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Pasword  must not be space");
                }
            }
        }

        // Automatic Get set
        public string userAddress { get; set; } // automatic return and set the value without declaring a global variable

        // constructor
        public Account(string userNameInput, string userPasswordInput, string userAddressInput)
        {
            UserName = userNameInput;
            UserPassword = userPasswordInput;
            userAddress = userAddressInput;
        }
    }
}