namespace TravelNest.Models.Hotel
{
    public class HotelRoomViewModel
{
    public string RoomNumber { get; set; }
    public bool IsOccupied { get; set; } 
    public decimal PricePerNight { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime CheckOutTime { get; set; }
    public string Name { get; set;}
    public string City { get; set;}

}


}