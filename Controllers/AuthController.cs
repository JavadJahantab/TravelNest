using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TravelNest.Models.User;
using TravelNest.service.User;
using TravelNest.data.Domain.User;

namespace TravelNest.Controllers;

    public class AuthController : Controller 
    {
        private UserService _userService;
        public AuthController(UserService userService){
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(UserViewModel model)
        {
        if (ModelState.IsValid)
        {
            var user=new User {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MobileNumber = model.MobileNumber,
                Password = model.Password,
                Email = model.Email,
            };

          await _userService.CreateUserAsync(user);
            return View(model);
        }
        return View();; 
        }



}