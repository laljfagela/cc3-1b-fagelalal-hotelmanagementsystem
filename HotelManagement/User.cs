using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        private string Password { get; set; }

        public User(string name, string address, string email, int phoneNumber, string password)
        {
            Name = name;
            Address = address;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}

