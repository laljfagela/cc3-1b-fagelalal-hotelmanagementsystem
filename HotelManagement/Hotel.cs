using System;
using System.Collections.Generic;

namespace HotelManagement
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
            Console.WriteLine($"Available rooms in {Name}:");
            foreach (HotelRoom room in Rooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Booked rooms in {Name}:");
            foreach (HotelRoom room in Rooms)
            {
                if (!room.IsAvailable)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }
    }
}
