using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Account
    {
        private static int s_accountSeed = 0;
        private int AccountPassword { get; set; }

        public Account()
        {
            AccountPassword = GenerateRandomPassword();
        }

        private int GenerateRandomPassword()
        {
            s_accountSeed++;
            return s_accountSeed;
        }

        public bool CheckPassword(int password)
        {
            return AccountPassword == password;
        }

        public void SetPassword(int password)
        {
            AccountPassword = password;
        }
    }
}
