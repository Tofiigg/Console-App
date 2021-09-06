using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Customer
    {
        public string fullName;
        public int ID;
        public int PhoneNumber;

        public Customer(string fullname, int id, int phonenumber)
        {
            this.fullName = fullname;
            this.ID = id;
            this.PhoneNumber = phonenumber;
        }
    }
}
