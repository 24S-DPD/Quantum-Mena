using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Quantum.Models;
using System.Security.Policy;

namespace Quantum.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            var events = EventsRepository.GetEvents();

            return View(events);
        }



        public IActionResult Events()
        {
            var events = EventsRepository.GetEvents();

            return View(events);

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
