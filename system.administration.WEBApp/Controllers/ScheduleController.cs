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
            var schedule = _scheduleServices.GetAllScheduleAsync().Result;
            return View(schedule);
        }
        public IActionResult AddSchedule(Schedule schedule)
        {
            _scheduleServices.AddScheduleAsync(schedule);
            return View(nameof(Index));
        }
        public async Task<IActionResult> DeleteScheduleAsync(int id)
        {
            var schedule = await _scheduleServices.GetScheduleByIdAsync(id);
            if (schedule == null)
            {
                throw new Exception("This Schedule Не існує ");
            }
            await _scheduleServices.DeleteScheduleAsync(schedule);
            return View(nameof(Index));
        }
        public async Task<IActionResult> UpdateScheduleAsync(int id, Schedule schedule)
        {
   
            if (id != schedule.id)
            {
                return Redirect($"Home/Error/");
            }
            await _scheduleServices.UpdateScheduleAsync(schedule);
            return View("Index", _scheduleServices.GetAllScheduleAsync().Result);
        }

    }
}

