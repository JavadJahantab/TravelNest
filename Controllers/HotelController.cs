using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelNest.Models.Hotel;
using TravelNest.Service.Hotel;

namespace TravelNest.Controllers;

public class HotelController : Controller
{
    private HotelService _hoteltService;
    public HotelController(HotelService hotelService){
            _hoteltService = hotelService;
    }
        [HttpGet]
        public IActionResult HotelSearch ()
        {
            return View();
        }


    [HttpPost]
    public IActionResult HotelSearch(HotelSearchViewModel searchViewModel)
    {
        if (ModelState.IsValid)
        {
                var hotels = _hoteltService.SearchHotels(searchViewModel);

                return View("~/Views/Hotel/HotelList.cshtml", hotels );

        } 
        return View();
    }

[HttpGet]
public IActionResult HotelList( List<HotelRoomViewModel> hotels)
{
    return View(hotels);
}

    [HttpGet]
    public IActionResult HotelReserve(HotelViewModel model)
    {
        return View();
    }

    [HttpGet]
    public IActionResult HotelReserve(HotelTicketPurchaseModel model)
    {
        return View();
    }

}
