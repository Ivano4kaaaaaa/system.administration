using Microsoft.AspNetCore.Mvc;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;

namespace system.administration.WEBApp.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ScheduleeServices _scheduleServices;
        public ScheduleController(ScheduleeServices scheduleServices)
        {
            _scheduleServices = scheduleServices;
        }
        public IActionResult Index()
        {
            return View(_scheduleServices.GetAllScheduleAsync().Result);
        }
        [HttpPost]
        public IActionResult AddSchedule(Schedule schedule)
        {
            _scheduleServices.AddScheduleAsync(schedule);
            return View(nameof(Index));
        }
        public async Task<IActionResult> DeleteScheduleAsync(int id)
        {
           _scheduleServices.DeleteScheduleAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateScheduleAsync(int id)
        {
            _scheduleServices.UpdateScheduleAsync(id);
            return RedirectToAction("Index");
        }
    }
}
