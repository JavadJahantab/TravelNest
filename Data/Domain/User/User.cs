using System;

namespace TravelNest.data.Domain.User
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; } 
        public string? NationalCode { get; set; }
        public List<Address>? Addresses { get; set; }
        public int? Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }


}