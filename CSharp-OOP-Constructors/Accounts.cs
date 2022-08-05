﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Constructors
{
    class Accounts
    {
        public string username;
        public string password;

        public Accounts(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void displayAccount()
        {
            Console.WriteLine($"Username: {username} \nPassword: {password}");
        }

        public void displayUsername()
        {
            Console.WriteLine($"Username {username}");
        }

    }
}
