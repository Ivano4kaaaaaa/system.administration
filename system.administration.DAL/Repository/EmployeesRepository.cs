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
            var employees = await _context.Employees.Where(e => e.id == empl.id).FirstOrDefaultAsync();
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
        
        public async Task<Employees> GetEmploeyesAsync(int id)
        {
            return await _context.Employees.Where(e => e.id == id).FirstOrDefaultAsync();
        }

        public async Task AddEmployeesAsync(Employees empl)
        {

            _context.Employees.AddAsync(empl);
            await _context.SaveChangesAsync();
        }


        public async Task<Employees> GetEmployessAsync(int id)
        {
            return await _context.Employees.Where(e => e.id == id).FirstAsync();
        }
    }
}