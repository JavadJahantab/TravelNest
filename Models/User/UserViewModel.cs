using System;


namespace TravelNest.Models.User
{
    public class UserViewModel
    {
        public string Password { get; set; } 
        public string Email { get; set; }

        public int? Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
    }
}
