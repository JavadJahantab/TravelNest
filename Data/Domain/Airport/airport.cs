using System;
using TravelNest.data.Domain.User;



namespace TravelNest.data.Domain.Airport
{

    public class Airport
    {
        public int AirportId { get; set; }
        public string AirportCode { get; set; }
        public Address Location { get; set; }
    }


}