using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace deliver_me_deliveries.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {


        // GET api/animals
        public IActionResult Index()
        {
            var allRestaurants = Restaurant.SearchRestaurants();
            return View(allRestaurants);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
          var allRestaurants = Restaurant.SearchRestaurants();
          return View("Index", allRestaurants);
        }
    }
}