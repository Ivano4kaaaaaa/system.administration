using admin.DAL.Context;
using admin.DAL.Entities;
using admin.DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
            private readonly SystemContextcs _contextcs;
            public EmployeesRepository(SystemContextcs contextcs)
            {
                _contextcs = contextcs;
            }

            public async Task DeleteEmployeesAsync(Employees empl)
            {
                var employees = await _contextcs.Employees.Where(e => e.id == empl.id).FirstOrDefaultAsync();
                _contextcs.Employees.Remove(employees);
                await _contextcs.SaveChangesAsync();
            }

            public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
            {
                return await _contextcs.Employees.ToListAsync();
            }

            public async Task UpdateEmployessAsync(Employees empl)
            {
                var employees = await _contextcs.Employees.Where(e => e.id == empl.id).FirstOrDefaultAsync();
                employees.position = empl.position;
                employees.surname = empl.surname;
                employees.address = empl.address;
                employees.phone_number = empl.phone_number;
                employees.city = empl.city;
                await _contextcs.SaveChangesAsync();
            }

            public async Task<Employees> GetEmploeyesAsync(int id)
            {
                return await _contextcs.Employees.Where(e => e.id == id).FirstOrDefaultAsync();
            }

            public async Task AddEmployeesAsync(Employees empl)
            {
                _contextcs.Employees.AddAsync(empl);
                await _contextcs.SaveChangesAsync();
            }


            public async Task<Employees> GetEmployessAsync(int id)
            {
                return await _contextcs.Employees.Where(e => e.id == id).FirstAsync();
            }
        }
}
