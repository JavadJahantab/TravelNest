using System;
using TravelNest.data.Domain.User;


namespace TravelNest.data.Domain.Flight
{
    public class FlightTicketPurchase
    {
        public int FlightTicketPurchaseId { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TicketPrice { get; set; }
    }
}