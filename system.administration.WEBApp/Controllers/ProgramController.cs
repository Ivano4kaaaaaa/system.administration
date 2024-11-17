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
            return View(_programServices.GetAllProgramAsync().Result);
        }
        [HttpGet]
        public IActionResult AddProgram(system.administration.DAL.Entities.Program program)
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

//[HttpPost]
//public IActionResult AddEmployees(Employees employee)
//{
//    _employeeServices.AddEmployeesAsync(employee);
//    return Redirect("/Employees/Index");
//}
//public async Task<IActionResult> DeleteEmployeesAsync(int id)
//{
//    _employeeServices.DeleteEmployeesAsync(id);
//    return RedirectToAction("Index");
//}

//public async Task<IActionResult> UpdateEmployee(int id)
//{
//    _employeeServices.UpdateEmployeesAsync(id);
//    return RedirectToAction("Index");
