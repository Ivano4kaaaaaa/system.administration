using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Context;
using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;

namespace system.administration.DAL.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly SystemContext _context;
        public EmployeesRepository(SystemContext context)
        {
            _context = context;
        }

        public async Task DeleteEmployeesAsync(Employees empl)
        {
            var employees = await _context.Employees.Where(e=> e.id == empl.id).FirstOrDefaultAsync();
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task UpdateEmployessAsync(Employees empl)
        {
            var employees = await _context.Employees.Where(e => e.id == empl.id).FirstOrDefaultAsync();
            employees.position = empl.position;
            employees.surname = empl.surname;
            employees.address = empl.address;
            employees.phone_number = empl.phone_number;
            employees.city = empl.city;
            await _context.SaveChangesAsync();
        }

       public async Task AddEmployeesAsync(Employees empl)
        {
            var employees = await _context.Employees.Where(e => e.id == empl.id).FirstOrDefaultAsync();
            employees.id = empl.id;
            empl.name = empl.name;
            employees.surname = empl.surname;
            employees.patronymic = empl.patronymic;
            employees.year_of_admission = empl.year_of_admission;
            employees.year_of_birth = empl.year_of_birth;
            employees.length_of_service = empl.length_of_service;
            employees.position = empl.position;
            employees.gender = empl.gender;
            employees.address = empl.address;
            employees.phone_number = empl.phone_number;
            employees.city = empl.city;
            await _context.SaveChangesAsync();
        }
    }
}

