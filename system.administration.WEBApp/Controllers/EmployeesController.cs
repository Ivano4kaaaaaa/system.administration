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
            var employees = _employeeServices.GetEmployeesAsync().Result;
            return View(employees);
        }

        public IActionResult AddEmployees(Employees employee)
        {
            _employeeServices.AddEmployeesAsync(employee);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteEmployeesAsync(int id)
        {
            var employee = await _employeeServices.GetEmployeesByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            await _employeeServices.DeleteEmployeesAsync(employee);
            return NoContent();
        }

        public async Task<IActionResult> UpdateEmployee(int id, Employees employee)
        {
            if (id != employee.id)
            {
                return BadRequest();
            }

            await _employeeServices.UpdateEmployeesAsync(employee);
            return NoContent();
        }
    }
}
