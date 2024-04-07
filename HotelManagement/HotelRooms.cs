using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public Program.RoomStyle Style { get; set; }
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public Hotel Hotel { get; set; }

        public HotelRoom(int roomNumber, Program.RoomStyle style, bool isAvailable, double price)
        {
            RoomNumber = roomNumber;
            Style = style;
            IsAvailable = isAvailable;
            Price = price;
        }
    }
}
