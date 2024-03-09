using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelNest.data;
using TravelNest.Models.Flight;

namespace TravelNest.Service.Flight
{
    public class FlightService
    {

        private readonly ApplicationDbContext _context;
        public FlightService(ApplicationDbContext context)
        {
            _context = context;

        }




public List<FlightViewModel> SearchFlight(FlightSearchViewModel searchViewModel)
{
    var flights = _context.Flights
        .Where(h => h.origin == searchViewModel.Origin)
       // .Where(h => h.date == searchViewModel.date)
        .Where(h => h.destination == searchViewModel.Destination);

    var flightvms = new List<FlightViewModel>();

    foreach (var flight in flights)
    {
        var flightViewModel = new FlightViewModel
        {
        
        Date1 = flight.date,
        Destination = flight.destination,
        TicketPrice = flight.TicketPrice,
        Origin = flight.origin,
   
        };

        flightvms.Add(flightViewModel);
    }


    return flightvms;
}
        
    }
}