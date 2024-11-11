using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
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
            var employees = _employeeServices.GetAllEmployeesAsync().Result;
            return View(employees);
        }

        public IActionResult AddEmployees(Employees employee)
        {
            _employeeServices.AddEmployeesAsync(employee);
            return View(nameof(Index));
        }

        public async Task<IActionResult> DeleteEmployeesAsync(int id)
        {
            var employee = await _employeeServices.GetEmploysByIdAsync(id);
            if (employee == null)
            {
                throw new Exception("This Employes Не існує");
            }

            await _employeeServices.DeleteEmployeesAsync(employee);
            return View(nameof(Index));
        }

        public async Task<IActionResult> UpdateEmployee(int id, Employees employee)
        {
            if (id != employee.id)
            {
                return Redirect($"Home/Error/");
            }

            await _employeeServices.UpdateEmployeesAsync(employee);
            return View("Index", _employeeServices.GetAllEmployeesAsync().Result);
        }
    }
}