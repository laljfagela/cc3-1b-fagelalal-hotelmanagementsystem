﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem;

using System;

namespace HotelManagement
{
    public class Reservation
    {
        public List<Hotel> Hotels { get; set; }
        public List<Guest> RegisteredUsers { get; set; }

        public int RegistrationNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Duration => (int)(CheckOutDate - CheckInDate).TotalDays;

        public Reservation(int registrationNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            RegistrationNumber = registrationNumber;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

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
    }
}

