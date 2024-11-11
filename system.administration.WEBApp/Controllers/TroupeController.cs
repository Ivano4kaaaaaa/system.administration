using Microsoft.AspNetCore.Mvc;
using system.administration.DAL.Entities;
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
            var troupe = _troupeServices.GetAllTroupeAsync().Result;
            return View(troupe);
        }
        public IActionResult AddTroupeAsync(Troupe troupe)
        {
            _troupeServices.AddTroupeAsync(troupe);
            return View(nameof(Index));
        }
        public async Task<IActionResult> DeleteTroupee(int id)
        {
            var troupe = _troupeServices.GetTroupeByIdAsync(id);
            if (troupe == null)
            {
                throw new Exception("This Troupe Не існує");
            }

            await _troupeServices.DeleteTroupeAsync(troupe);
            return View(nameof(Index));
        }
        public async Task<IActionResult> UpdateTroupe(int id, Troupe troupe)
        {
            if(id != troupe.id)
            {
                return Redirect($"Home/Error/");
            }
            await _troupeServices.UpdateTroupeAsync(troupe);
            return View("Index", _troupeServices.GetAllTroupeAsync().Result);
        }
    }
}
