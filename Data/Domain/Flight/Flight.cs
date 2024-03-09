using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNest.data.Domain.Flight
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string? DepartureAirport { get; set; }
        public string origin { get; set; }
        public DateTime date { get; set; }
        public string destination {get; set;}

        public decimal TicketPrice { get; set; }
        public FlightType Type { get; set; }
    }

}