using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagementSystem
{
    public class Reservation
    {
        public int RegistrationNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Duration => (int)(CheckOutDate - CheckInDate).TotalDays;

        private static int registrationSeed = 0;

        public Reservation(int registrationNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            RegistrationNumber = registrationNumber;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        private int GenerateRegistrationNumber()
        {
            return ++registrationSeed;
        }
    }

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

            Reservation reservation = new Reservation(GenerateRegistrationNumber(), checkInDate, checkOutDate);
 
            room.IsAvailable = false;
        }

        public int GenerateRegistrationNumber()
        {

            return 0; 
        }

        public void DisplayAvailableRooms(Hotel hotel)
        {
            DisplayAvailableRooms(hotel);
        }

        public void DisplayHotelInfo(Hotel hotel)
        {
            DisplayHotelInfo(hotel);
        }


        public void DisplayReservationDetails(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public void AddHotel(Hotel hotel)
        {
            Hotels.Add(hotel);
        }

        public void DisplayHotels()
        {
            foreach (var hotel in Hotels)
            {
                Console.WriteLine($"Hotel Name: {hotel.Name}");
                Console.WriteLine($"Address: {hotel.Address}");
            }
        }

        public void BookRoom(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            if (hotel == null || room == null || guest == null)
            {
                Console.WriteLine("Invalid input. Please provide valid hotel, room, and guest information.");
                return;
            }

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
            guest.AddReservation(reservation);
            room.IsAvailable = false;

            Console.WriteLine($"Room booked successfully for {guest.Name} from {checkInDate.ToShortDateString()} to {checkOutDate.ToShortDateString()}.");
        }
    }
}


