using Microsoft.AspNetCore.Mvc;
using admin.DAL.Entities;
using systemadministration.BLL.Services;

namespace system.administration.WEBApp.Controllers
{
    public class ProgramController : Controller
    {
        private readonly ProgrammServices _programServices;

        public ProgramController(ProgrammServices programServices)
        {
            _programServices = programServices;
        }
        public IActionResult Index()
        {
            return View(_programServices.GetAllProgramAsync().Result);
        }
        [HttpGet]
        public IActionResult AddProgram(admin.DAL.Entities.Program program)
        {
            _programServices.AddProgramAsync(program);
            return Redirect("/Program/index");
        }
        public async Task<IActionResult> DeleteProgramAsync(int id)
        {
            _programServices.DeleteProgramAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateProgram(int id)
        {
            _programServices.UpdateProgramAsync(id);
            return RedirectToAction("Index");
        }
    }
}
