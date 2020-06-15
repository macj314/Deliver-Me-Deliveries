using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using deliver_me_deliveries.Models;

namespace deliver_me_deliveries.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {


        // GET api/animals
        public IActionResult Index()
        {
            var allRestaurants = Restaurant.GetAll();
            return View(allRestaurants);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
          var allRestaurants = Restaurant.GetAll();
          return View("Index", allRestaurants);
        }
    }
}