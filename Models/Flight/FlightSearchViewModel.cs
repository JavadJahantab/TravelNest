using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNest.Models.Flight
{
    public class FlightSearchViewModel
    {
        public string Origin { get; set; }
        public DateTime? Date1 { get; set; }
        public string Destination {get; set;}
        
    }
}