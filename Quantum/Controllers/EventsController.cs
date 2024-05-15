using Microsoft.AspNetCore.Mvc;

namespace Quantum.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Events()
        {
            return View();
        }


    }
}
