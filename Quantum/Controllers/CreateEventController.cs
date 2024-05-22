using Microsoft.AspNetCore.Mvc;
using Quantum.Data;
using Quantum.Models;

namespace Quantum.Controllers
{
    public class CreateEventController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public CreateEventController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventViewModel event_MDL)
        {
            Event event_INS = new Event
            {
                Name = event_MDL.Name,
                Date = event_MDL.Date
            };

            await dbContext.DbSet_Events.AddAsync(event_INS);
            await dbContext.SaveChangesAsync();


            return View();
        }


    }
}
