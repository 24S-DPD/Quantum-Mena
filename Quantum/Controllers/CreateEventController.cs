using Microsoft.AspNetCore.Mvc;

namespace Quantum.Controllers
{
    public class CreateEventController : Controller
    {
        public IActionResult CreateEvent()
        {
            return View();
        }
    }
}
