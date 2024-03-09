using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelNest.Models.Hotel
{
    public class HotelSearchViewModel
    {
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; } 
        public string City {get; set;}

    }
}