﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Guest : User
    {
        public int TotalNumOfRooms { get; set; }

        public Guest(string name, string address, string email, int phoneNumber, int totalNumOfRooms) :
            base(name, address, email, phoneNumber)
        {
            TotalNumOfRooms = totalNumOfRooms;
        }
    }
}