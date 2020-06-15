using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace deliver_me_deliveries.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }


        // GET api/animals

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string name, string details, string breed)
        {
            var query = _db.Animals.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (details != null)
            {
                query = query.Where(entry => entry.Details == details);
            }
            if (breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }
            return query.ToList();
        }