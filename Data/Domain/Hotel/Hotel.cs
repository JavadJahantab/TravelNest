using System;
using TravelNest.data.Domain.User;


namespace TravelNest.data.Domain.Hotel
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public Address Location { get; set; }
        public int NumberOfRooms { get; set; }
        public HotelStarRating StarRating { get; set; } 
        public List<HotelRoom> Rooms { get; set; }
    }


}