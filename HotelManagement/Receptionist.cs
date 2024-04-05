using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagement
{
    public class Receptionist : Guest
    {
        private HotelManagementSystem hotelManagementSystem;

        public Receptionist(HotelManagementSystem hotelManagementSystem)
        {
            this.hotelManagementSystem = hotelManagementSystem;
        }

        public void CheckIn(Guest guest, HotelRoom room, DateTime checkInDate, DateTime checkOutDate)
        {
            if (room.IsAvailable)
            {
                hotelManagementSystem.MakeReservation(room.Hotel, room, guest, checkInDate, checkOutDate);
                Console.WriteLine($"{guest.Name} has successfully checked into room {room.RoomNumber}.");
            }
            else
            {
                Console.WriteLine($"Room {room.RoomNumber} is not available for check-in.");
            }
        }

        public void CheckOut(Guest guest, HotelRoom room)
        {
            Console.WriteLine($"{guest.Name} has successfully checked out from room {room.RoomNumber}.");
        }

        public void DisplayAvailableRooms(Hotel hotel)
        {
            hotelManagementSystem.DisplayAvailableRooms(hotel);
        }

        public void DisplayHotelInfo(Hotel hotel)
        {
            hotelManagementSystem.DisplayHotelInfo(hotel);
        }
    }
}

