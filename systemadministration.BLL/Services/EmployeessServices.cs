using admin.DAL.Entities;
using admin.DAL.IRepository;
using admin.DAL.Entities;
using admin.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public class EmployeessServices
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeessServices(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }


        public async Task AddEmployeesAsync(Employees empl)
        {
            await _employeesRepository.AddEmployeesAsync(empl);
        }

        public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            return await _employeesRepository.GetAllEmployeesAsync();
        }
        public async Task<Employees> GetEmployeesByIdAsync(int id)
        {
            return await _employeesRepository.GetEmployessAsync(id);
        }    
        public async Task UpdateEmployeesAsync(int id)
        {
            var employee = await _employeesRepository.GetEmploeyesAsync(id);
            if (employee != null)
            {
                await _employeesRepository.UpdateEmployessAsync(employee);
            }
            else
            {
                throw new Exception("Працівника оновлено");
            }
        }

        public async Task DeleteEmployeesAsync(int id)
        {
            var employee = await _employeesRepository.GetEmploeyesAsync(id);
            if (employee != null)
            {
                await _employeesRepository.DeleteEmployeesAsync(employee);
            }
            else
            {
                throw new Exception("Працівника не знайдено");
            }  
        }
    }
}