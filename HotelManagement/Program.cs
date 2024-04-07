using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagementSystem
{
    public class Program
    {
        public enum RoomStyle
        {
            TwinRoom,
            QueenRoom,
            KingRoom
        }

        static void Main(string[] args)
        {
            // Hotel 1
            List<HotelRoom> Moonlitrooms = new List<HotelRoom>();

            HotelRoom Moonlitroom1 = new HotelRoom(302, RoomStyle.TwinRoom, true, 800);
            HotelRoom Moonlitroom2 = new HotelRoom(303, RoomStyle.QueenRoom, true, 1000);
            HotelRoom Moonlitroom3 = new HotelRoom(304, RoomStyle.KingRoom, true, 1200);

            Moonlitrooms.Add(Moonlitroom1);
            Moonlitrooms.Add(Moonlitroom2);
            Moonlitrooms.Add(Moonlitroom3);

            Hotel MoonlitHotel = new Hotel("Moonlit Hotel", "Splingeard Street, Baguio City", Moonlitrooms);

            // Hotel 2
            List<HotelRoom> Starlitrooms = new List<HotelRoom>();

            HotelRoom Starlitroom1 = new HotelRoom(402, RoomStyle.TwinRoom, true, 800);
            HotelRoom Starlitroom2 = new HotelRoom(403, RoomStyle.QueenRoom, true, 1000);
            HotelRoom Starlitroom3 = new HotelRoom(404, RoomStyle.KingRoom, true, 1200);

            Starlitrooms.Add(Starlitroom1);
            Starlitrooms.Add(Starlitroom2);
            Starlitrooms.Add(Starlitroom3);

            Hotel StarlitHotel = new Hotel("Starlit Hotel", "Wanderwall Street, Baguio City", Starlitrooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(MoonlitHotel);
            hms.AddHotel(StarlitHotel);


            hms.DisplayHotels();
            StarlitHotel.DisplayAvailableRooms();

            Guest Jinoo = new Guest("Jinoo", "Gangnam, South Korea", "jinoolim@gmail.com", 987654321, "lucci0706");
            hms.RegisterUser(Jinoo);
            hms.BookRoom(StarlitHotel, StarlitHotel.Rooms[0], Jinoo, DateTime.Now, new DateTime(2024, 04, 06));

            StarlitHotel.DisplayBookedRooms();
            Jinoo.DisplayReservations();

            Receptionist Hyeonjin = new Receptionist(hms, "Hyeonjin", "Seoul, South Korea", "hyeonjin@gmail.com", "password", 123456789, 0);
            hms.RegisterUser(Hyeonjin);
            Reservation reservation = new Reservation(1, new DateTime(2024, 05, 02), new DateTime(2024, 05, 22));
            Hyeonjin.AddReservation(reservation);

            Jinoo.DisplayReservations();
            hms.DisplayReservationDetails(reservation);
        }
    }
}

