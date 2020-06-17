using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace deliver_me_deliveries.Controllers
{
    public class RestaurantsController : Controller
    {  
        public IActionResult Index()
        {
            var allRestaurants = Restaurant.GetRestaurants();
            return View(allRestaurants);
        }

        [HttpGet]
        public IActionResult GetAll()
        {     
            var allRestaurants = Restaurant.GetRestaurants();
            return View("Index", allRestaurants);
        }
        
        [HttpPost]
        [Route("restaurant/{search}")]
        public IActionResult Search(string streetAddress)
        {
            var searchResults = Restaurant.Search(streetAddress);
            return View(searchResults);
        }
    }
}