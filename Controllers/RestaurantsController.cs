using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace deliver_me_deliveries.Controllers
{

    // [Route("api/[controller]")]
    // [ApiController]
    public class RestaurantsController : Controller
    {

        // GET api/Restaurant
       
        public IActionResult Index()
        {
            var allRestaurants = Restaurant.GetRestaurants();
            return View(allRestaurants["restaurants"]);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // string output = "?";
            // if (Location != "")
            // {
            // output += $"location={Location}"
            // }
        
          var allRestaurants = Restaurant.GetRestaurants();
        //   Console.WriteLine("--------------------------------------------------");
        //   Console.WriteLine(allRestaurants);
          return View("Index", allRestaurants);
        }

    
    }
}