
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelNest.Models.Flight;
using TravelNest.Service.Flight;

namespace TravelNest.Controllers;
public class FlightController : Controller
{   
    private FlightService _flightService;
    public FlightController(FlightService flightService){
            _flightService = flightService;
    }

    [HttpGet]
    public IActionResult FlightSearch()
    {
        return View();
    }

    [HttpPost]
    public IActionResult FlightSearch(FlightSearchViewModel searchViewModel)
    {
        if (ModelState.IsValid)
        {
                var flights = _flightService.SearchFlight(searchViewModel);

                return View("~/Views/Flight/FlightList.cshtml",flights);

        } 
        return View();
    }

    public IActionResult FlightList(List<FlightViewModel> flightListViewModel)
    {
        return View(flightListViewModel);
    }

    [HttpGet]
    public IActionResult FlightReserve(FlightViewModel model)
    {
        return View();
    }

    [HttpPost]
    public IActionResult FlightReserve(FlightTicketPurchaseModel model)
    {
        return View();
    }


}