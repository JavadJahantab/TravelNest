using System;
using Microsoft.EntityFrameworkCore;
using TravelNest.data.Domain.User;
using TravelNest.data.Domain.Flight;
using TravelNest.data.Domain.Hotel;
using TravelNest.data.Domain.Airport;

namespace TravelNest.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }

        public DbSet<FlightTicketPurchase> FlightTicketPurchases { get; set; }


    }
}