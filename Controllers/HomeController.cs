using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Mvc;

namespace deliver_me_deliveries.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
