using Microsoft.AspNetCore.Mvc;
using system.administration.DAL.Entities;

namespace system.administration.WEBApp.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees() { employee_id = 1, gender = "чоловік" });
            employees.Add(new Employees() { employee_id = 2, gender = "жінка" });

            return View(employees);
        }
        public IActionResult AddEmployees()
        {
         
            return View();
        }
        //public IActionResult AddEmployees(Employees employees)
        //{
        //    return View();
        //}
    }

}
