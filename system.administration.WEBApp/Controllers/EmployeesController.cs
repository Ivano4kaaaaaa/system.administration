using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using admin.DAL.Entities;
using systemadministration.BLL.Services;

namespace system.administration.WEBApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeessServices _employeeServices;

        public EmployeesController(EmployeessServices employeesServices)
        {
            _employeeServices = employeesServices;
        }
        public IActionResult Index()
        {
            //var employees = _employeeServices.GetAllEmployeesAsync().Result;
            //return View(employees);
            return View(_employeeServices.GetAllEmployeesAsync().Result);
        } 
        [HttpGet]   
        public IActionResult AddEmployees()
        {
          
            return View();
        }
       [HttpPost]
        public IActionResult AddEmployees(Employees employee)
        {
            _employeeServices.AddEmployeesAsync(employee);
            return Redirect("/Employees/Index");
        }
        public async Task<IActionResult> DeleteEmployeesAsync(int id)
        {
            _employeeServices.DeleteEmployeesAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateEmployee(int id)
        {
           _employeeServices.UpdateEmployeesAsync(id);
            return RedirectToAction("Index");
        }
    }
}