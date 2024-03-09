using System;
using TravelNest.data.Domain.User;


namespace TravelNest.data.Domain.Hotel
{
    public class RoomReservation
    {
        public int RoomReservationId { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }
        public int HotelId { get; set; }
        public Hotel hotel { get; set; }
        public int RoomId { get; set; }
        public HotelRoom Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
    }

}