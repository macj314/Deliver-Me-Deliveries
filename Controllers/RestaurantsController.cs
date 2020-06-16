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
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {     
          var allRestaurants = Restaurant.GetRestaurants();
          return View("Index", allRestaurants);
        }

        [Route("restaurant/{search}")]
        public IActionResult Search()
        {
            var searchResults = Restaurant.Search();
            return View();
        }
    }
}