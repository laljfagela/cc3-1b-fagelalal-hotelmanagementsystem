using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagement
    {
        public List<Hotel> Hotels { get; set; }
        public List<Guest> RegisteredUsers { get; set; }

        public HotelManagement()
        {
            Hotels = new List<Hotel>();
            RegisteredUsers = new List<Guest>();
        }


        public void RegisterUser(Guest guest)
        {
            RegisteredUsers.Add(guest);
        }

        public void MakeReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            if (!hotel.Rooms.Contains(room))
            {
                Console.WriteLine("Room not found in the hotel.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is not available for the specified dates.");
                return;
            }

            Reservation reservation = new Reservation(room.RoomNumber, checkInDate, checkOutDate);
            hotel.Rooms.Add(room);
            room.IsAvailable = false;
        }

        public void DisplayHotels()
        {
            foreach (var hotel in Hotels)
            {
                Console.WriteLine($"Hotel Name: {hotel.Name}");
                Console.WriteLine($"Address: {hotel.Address}");
                Console.WriteLine("Available Rooms:");
                hotel.DisplayAvailableRooms();
            }
        }

        public void DisplayAvailableRooms()
        {
            foreach (var room in HotelRoom)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}");
                    Console.WriteLine($"Room Style: {room.Style}");
                    Console.WriteLine($"Price: {room.Price}");
                }
            }
        }


        public void DisplayHotelInfo(Hotel hotel)
        {
            hotel.DisplayHotelInfo();
        }

        public void DisplayBookedRooms(Hotel hotel)
        {
            hotel.DisplayBookedRooms();
        }

    }
}


