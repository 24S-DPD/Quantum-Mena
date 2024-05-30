using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

      //  [HttpPost]
        public async Task<IActionResult> Delete(int nEventID)
        {
            var evnt = await dbContext.DbSet_Events
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == nEventID);


            if (evnt != null)
            {
                dbContext.DbSet_Events.Remove(evnt);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("GetEvents" ,"Events" );




        }


    }
}
