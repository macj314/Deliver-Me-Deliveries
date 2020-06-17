using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using deliver_me_deliveries.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using PagedList;
using PagedList.Mvc;

namespace deliver_me_deliveries.Controllers
{

    // [Route("api/[controller]")]
    // [ApiController]
    public class RestaurantsController : Controller
    {

        // GET api/Restaurant
       
        public IActionResult Index()
        {
            
            // int pageNumber = (page ?? 1);
            // int pageSize = 10;
            // ViewBag.Page = (pageNumber).ToString();
            var allRestaurants = Restaurant.GetRestaurants();
            return View(allRestaurants);
        }
        //   public IActionResult Page(string page)
        // {
          
        //   var allRestaurants = Restaurant.GetRestaurants();
        // int pageSize = 10;
        //   ViewBag.Page = (int.Parse(page)+1).ToString();
        //   ViewBag.PageSize = 10;
        //   return View("Index", allRestaurants.ToPagedList(ViewBag.Page,pageSize));
        // }

        [HttpGet]
        public IActionResult GetAll()
        {     
          var allRestaurants = Restaurant.GetRestaurants();
          return View("Index", allRestaurants);
        }
       
    }
}

// public class StudentController : ApiController
// {
//     public StudentController()
//     {
//     }

//     public IHttpActionResult GetAllStudents(bool includeAddress = false)
//     {
//         IList<StudentViewModel> students = null;

//         using (var ctx = new SchoolDBEntities())
//         {
//             students = ctx.Students.Include("StudentAddress").Select(s => new StudentViewModel()
//             {
//                 Id = s.StudentID,
//                 FirstName = s.FirstName,
//                 LastName = s.LastName,
//                 Address = s.StudentAddress == null || includeAddress == false ? null : new AddressViewModel()
//                 {
//                     StudentId = s.StudentAddress.StudentID,
//                     Address1 = s.StudentAddress.Address1,
//                     Address2 = s.StudentAddress.Address2,
//                     City = s.StudentAddress.City,
//                     State = s.StudentAddress.State
//                 }
//             }).ToList<StudentViewModel>();
//         }

//         if (students.Count == 0)
//         {
//             return NotFound();
//         }

//         return Ok(students);
//     }
// }
