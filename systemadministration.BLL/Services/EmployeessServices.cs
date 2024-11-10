using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
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

            public async Task<IEnumerable<Employees>> AllEmployeesAsync(Employees empl)
            {
               return await _employeesRepository.GetAllEmployeesAsync();
            }

            public async Task UpdateEmployeesAsync(Employees empl)
            {
                await _employeesRepository.UpdateEmployessAsync(empl);
            }

            public  async Task DeleteEmployeesAsync(Employees empl)
            {
            await _employeesRepository.DeleteEmployeesAsync(empl);
            }
        }
    }



