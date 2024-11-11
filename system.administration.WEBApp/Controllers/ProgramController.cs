using Microsoft.AspNetCore.Mvc;
using system.administration.DAL.Entities;
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
            var programs = _programServices.GetAllProgramAsync().Result;
            return View(programs);
        }
        public IActionResult AddProgram(system.administration.DAL.Entities.Program program)
        {
            _programServices.AddProgramAsync(program);
            return View(nameof(Index));
        }
        public async Task<IActionResult> DeleteProgramAsync(int id)
        {
            system.administration.DAL.Entities.Program  program = await _programServices.GetProgramByIdAsync(id);
            if (program == null)
            {
                throw new Exception("This Program Не існує ");
            }
            await _programServices.DeleteProgramAsync(program);
            return View(nameof(Index));
        }    
        public async Task<IActionResult> UpdateProgram(int id, system.administration.DAL.Entities.Program program)
        {
            if (id != program.id ) {
                return Redirect($"Home/Error/");
        }
            await _programServices.UpdateProgramAsync(program);
            return View("Index", _programServices.GetAllProgramAsync().Result );
            
            }
        
    }
}
