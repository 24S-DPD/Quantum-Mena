using Microsoft.AspNetCore.Mvc;

namespace Quantum.Controllers
{
    public class CheckInController : Controller
    {
        public IActionResult CheckIn()
        {
            return View();
        }
    }
}
