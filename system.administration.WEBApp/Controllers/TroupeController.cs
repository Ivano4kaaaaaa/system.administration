using Microsoft.AspNetCore.Mvc;
using admin.DAL.Entities;
using systemadministration.BLL.Services;

namespace system.administration.WEBApp.Controllers
{
    public class TroupeController : Controller
    {
        private readonly TroupeeServices  _troupeServices;
        public TroupeController(TroupeeServices troupeServices)
        {
            _troupeServices = troupeServices;
        }

        public IActionResult Index()
        {
            return View( _troupeServices.GetAllTroupeAsync().Result);
        }
        [HttpPost]
        public IActionResult AddTroupeAsync(Troupe troupe)
        {
            _troupeServices.AddTroupeAsync(troupe);
            return View(nameof(Index));
        }
        public async Task<IActionResult> DeleteTroupee(int id)
        {
            _troupeServices.DeleteTroupeAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateTroupe(int id)
        {
            _troupeServices.UpdateTroupeAsync(id);
            return RedirectToAction("Index");
        }  
    }
}
