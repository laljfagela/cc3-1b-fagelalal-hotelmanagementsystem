using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem;

namespace HotelManagementSystem
{
    public class Guest : User
    {
        public int TotalNumOfRooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Guest(string name, string address, string email, int phoneNumber, string password) : base(name, address, email, phoneNumber, password)
        {
            Reservations = new List<Reservation>();
        }

        public void DisplayReservations()
        {
            DisplayReservations();
        }

        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }
    }
}
