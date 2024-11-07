using Microsoft.AspNetCore.Mvc;

namespace system.administration.WEBApp.Controllers
{
    public class ProgramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
