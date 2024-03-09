using System;
using TravelNest.Models.Flight;


namespace TravelNest.Models.Flight
{
    public class FlightViewModel
    {

        public string? FlightNumber { get; set; }
        public string? DepartureAirport { get; set; }
        public string? ArrivalAirport { get; set; }
        public string Origin { get; set; }
        public DateTime Date1 { get; set; }
        public string Destination {get; set;}
        public decimal TicketPrice { get; set; }

        public FlightTypeViewModel? Type { get; set; }
    }
}
