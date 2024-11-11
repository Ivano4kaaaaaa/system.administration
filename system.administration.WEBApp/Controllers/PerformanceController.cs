using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;

namespace system.administration.WEBApp.Controllers
{
    public class PerformanceController : Controller
    {
        private readonly PerformanceeServices _performanceeServices;

        public PerformanceController(PerformanceeServices performanceeServices)
        {
            _performanceeServices = performanceeServices;
        }

        public IActionResult Index()
        {
            var performance = _performanceeServices.GetAllPerformanceAsync().Result;
            return View(performance);
        }

        public IActionResult AddPerformance(Performance performance)
        {
            _performanceeServices.AddPerformanceAsync(performance);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeletePerformanceAsync(int id, Performance perf)
        {
            var performance = await _performanceeServices.GetPerformanceByIdAsync(id);
            if (performance == null)
            {
                return NotFound();
            }

            await _performanceeServices.DeletePerformanceAsync(perf);
            return NoContent();
        }

        public async Task<IActionResult> UpdatePerformance(int id, Performance performance)
        {
            if (id != performance.id)
            {
                return Redirect($"Home/Error/");
            }

            await _performanceeServices.UpdatePerformance(performance);
            return View("Index", _performanceeServices.GetAllPerformanceAsync().Result);
        }
    }
}


