using system.administration.DAL.Entities;
using system.administration.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.IRepository
{
    public interface IEmployeesRepository 
    {
        public Task<IEnumerable<Employees>> GetAllEmployeesAsync();
       
        public Task AddEmployeesAsync(Employees empl);
        public Task DeleteEmployeesAsync(Employees empl);
        public Task UpdateEmployessAsync(Employees empl);
        Task<Employees> GetEmployessAsync(int id);
        public Task<Employees> GetEmploeyesAsync(int id);
    }
}
