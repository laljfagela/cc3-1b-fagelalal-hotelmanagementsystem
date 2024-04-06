using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HotelManagement
{
    using System;
    using System.Collections.Generic;

    namespace HotelManagement
    {
        public class HotelManagementSystem
        {
            public List<Hotel> Hotels { get; set; }
            public List<Guest> RegisteredUsers { get; set; }

            public HotelManagementSystem()
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

            public void DisplayAvailableRooms(Hotel hotel)
            {
                Console.WriteLine($"Available rooms in {hotel.Name}:");
                foreach (HotelRoom room in hotel.Rooms)
                {
                    if (room.IsAvailable)
                    {
                        Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                    }
                }
            }

            public void DisplayBookedRooms(Hotel hotel)
            {
                Console.WriteLine($"Booked rooms in {hotel.Name}:");
                foreach (HotelRoom room in hotel.Rooms)
                {
                    if (!room.IsAvailable)
                    {
                        Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                    }
                }
            }

            public void DisplayHotelInfo(Hotel hotel)
            {
                Console.WriteLine($"Hotel Name: {hotel.Name}");
                Console.WriteLine($"Hotel Address: {hotel.Address}");
                Console.WriteLine($"Number of Rooms: {hotel.Rooms.Count}");
            }
        }
    }

}


