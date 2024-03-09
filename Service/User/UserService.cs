using System;
using Microsoft.EntityFrameworkCore;
using TravelNest.data;
using TravelNest.data.Domain.User;
using TravelNest.Models.User;


namespace TravelNest.service.User
{


    public class UserService
    {
        private readonly ApplicationDbContext _context;


        public UserService(ApplicationDbContext context)
        {
            _context = context;

        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public async Task<bool> CreateUserAsync(data.Domain.User.User user)
        {
            _context.Users.Add(user);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<UserViewModel> FindByNameAsync(string username)
        {
            var user= await _context.Users.FirstOrDefaultAsync();
            UserViewModel userViewModel = new UserViewModel();
            return userViewModel;
        }

        public async Task<bool> CheckPasswordAsync(String username, string password)
        {
            
            return true;
        }



    }
}

