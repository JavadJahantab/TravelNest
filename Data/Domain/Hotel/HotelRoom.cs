namespace TravelNest.data.Domain.Hotel
{
    public class HotelRoom
{
    public int HotelRoomId { get; set; }
    public bool? IsOccupied { get; set; } 
    public decimal PricePerNight { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime CheckOutTime { get; set; }
    public string City { get; set; }

    public string Name { get; set; }

}


}