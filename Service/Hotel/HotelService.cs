using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelNest.Models.Hotel;
using TravelNest.data;
using TravelNest.data.Domain.Hotel;

namespace TravelNest.Service.Hotel
{
        public class HotelService
    {
        
    
        private readonly ApplicationDbContext _context;
        public HotelService(ApplicationDbContext context)
        {
            _context = context;

        }




public  List<HotelRoomViewModel> SearchHotels(HotelSearchViewModel searchViewModel)
{
    var rooms = _context.HotelRooms
        //.Where(h => h.CheckInTime >= searchViewModel.CheckInTime)
        //.Where(h => h.CheckOutTime <= searchViewModel.CheckOutTime)
        .Where(h => h.City == searchViewModel.City);

    var hotelRoomViewModels = new List<HotelRoomViewModel>();

    foreach (var room in rooms)
    {
        var hotelRoomViewModel = new HotelRoomViewModel
        {
            PricePerNight = room.PricePerNight,
            CheckInTime = room.CheckInTime,
            CheckOutTime = room.CheckOutTime,
            Name = room.Name,
            City = room.City
   
        };

        hotelRoomViewModels.Add(hotelRoomViewModel);
    }


    return hotelRoomViewModels;
}


    }
}
