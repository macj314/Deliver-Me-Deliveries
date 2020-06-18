using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Diagnostics;

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

        public IActionResult Search(string addressSearch, string extraTerm = "")
        {        
            var searchResults = Restaurant.Search(addressSearch, extraTerm);
            return View("Search", searchResults);
        }
        
    }
}
