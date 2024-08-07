﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Quantum.Data;
using Quantum.Models;
//using AWSDBConnect.Data;


namespace Quantum.Controllers
{
    public class EventsController : Controller
    {
        //public IActionResult Index()
        //{
        //    var events = EventsRepository.GetEvents();

        //    return View(events);
        //}


        //private  ApplicationDbContext _context;

        //[HttpGet]
        //public IActionResult AddEvent()
        //{
        //    return View();
        //}


        //* Private Property - dbContext
        private readonly ApplicationDbContext _dbContext;

        public EventsController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }




        public IActionResult Events()
        {
           
            List<Event> events = EventsRepository.GetEvents();

            return View(events);
        }



        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var Events_LST = await _dbContext.DbSet_Events.ToListAsync();
            
            
            
            return View(Events_LST);
        }


        public IActionResult Edit( int intID , string? strName)
        {
            Event eventOBJ = new Event();
            eventOBJ.Id = 700124;
            eventOBJ.Name = "Developers Meeting";


            Event eventOBJ2 = new Event { Id = intID, Name = strName };

            return View(eventOBJ);
        }

       


    }
}
