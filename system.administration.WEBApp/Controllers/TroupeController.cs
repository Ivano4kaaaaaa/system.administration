using Microsoft.AspNetCore.Mvc;

namespace system.administration.WEBApp.Controllers
{
    public class TroupeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
