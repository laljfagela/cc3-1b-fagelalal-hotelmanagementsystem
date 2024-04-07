using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist : Guest
    {
        private readonly HotelManagementSystem hotelManagementSystem;

        public Receptionist(HotelManagementSystem hotelManagementSystem, string name, string address, string email, string password, int phoneNumber, int totalNumOfRooms) :
            base(name, address, email, phoneNumber, password)
        {
            this.hotelManagementSystem = hotelManagementSystem ?? throw new ArgumentNullException(nameof(hotelManagementSystem));
        }

        public void CheckIn(Guest guest, HotelRoom room, DateTime checkInDate, DateTime checkOutDate)
        {
            if (room.IsAvailable)
            {
                hotelManagementSystem.MakeReservation(room.Hotel, room, guest, checkInDate, checkOutDate);
            }
        }

        public void CheckOut(Guest guest, HotelRoom room)
        {
            CheckOut(guest, room);  
        }

        public void DisplayAvailableRooms(Hotel hotel)
        {
            hotelManagementSystem.DisplayAvailableRooms(hotel);
        }

        public void DisplayHotelInfo(Hotel hotel)
        {
            hotelManagementSystem.DisplayHotelInfo(hotel);
        }

        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }
    }
}


