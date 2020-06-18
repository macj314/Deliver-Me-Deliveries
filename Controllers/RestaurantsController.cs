using Microsoft.AspNetCore.Mvc;
using deliver_me_deliveries.Models;

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

        [HttpGet("{ApiKey}")]
        public IActionResult Details(string ApiKey)
        {           
          var restaurant = Restaurant.GetDetail(ApiKey);            
          return View(restaurant);
        }        
    }
}