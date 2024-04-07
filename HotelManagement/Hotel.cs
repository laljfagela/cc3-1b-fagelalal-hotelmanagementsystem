using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Isavailable { get; set; }
        public List<HotelRoom> Rooms { get; set; }

        public Hotel(string name, string address, List<HotelRoom> rooms)
        {
            Name = name;
            Address = address;
            Rooms = rooms;
        }

        public void DisplayAvailableRooms()
        {
            DisplayAvailableRooms();
        }

        public void DisplayBookedRooms()
        {
           DisplayBookedRooms();
        }
    }
}
