using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;

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
            //var performance = _performanceeServices.GetAllPerformanceAsync().Result;
            //return View(performance);
            return View(_performanceeServices.GetAllPerformanceAsync().Result);
        }
        [HttpGet]
        public IActionResult AddPerformance(Performance performance)
        {
            _performanceeServices.AddPerformanceAsync(performance);
            return Redirect("/Performance/index");
        }

        public async Task<IActionResult> DeletePerformanceAsync(int id)
        {
            _performanceeServices.DeletePerformanceAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdatePerformance(int id)
        {
            _performanceeServices.UpdatePerformance(id);
            return RedirectToAction("Index");
        }
    }
}
