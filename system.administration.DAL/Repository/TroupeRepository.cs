using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Context;
using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Repository
{
    public class TroupeRepository : ITroupeRepository
    {
        private readonly SystemContext _context;
        public TroupeRepository(SystemContext context)
        {
            _context = context;
        }

   

    //    public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
    //    {
    //        return await _context.Employees.ToListAsync();
    //    }


    public async Task AddTroupeAsync(Troupe tr)
        {
            var troupe = await _context.Troupes.Where(t=> t.id == tr.id).FirstOrDefaultAsync();
            troupe.id = tr.id;
            troupe.employeess_id = tr.employeess_id;
            troupe.performancees_id = tr.performancees_id;
            troupe.role = tr.role;
            await _context.SaveChangesAsync();
    }

        public async Task DeleteTroupeAsync(Troupe tr)
        {
            var troupe = await _context.Troupes.Where(t => t.id == tr.id).FirstOrDefaultAsync();
           _context.Troupes.Remove(troupe);
            await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Troupe>> GetAllTroupeAsync()
        {
            return await _context.Troupes.ToListAsync();
        }

        public async Task<Troupe> GetTroupeByIdAsync(int id)
        {
            return await _context.Troupes.Where(t => t.id == id).FirstAsync();
        }

        public async Task UpdateTroupeAsync(Troupe tr)
        {
            var troupe = await _context.Troupes.Where(t => t.id == tr.id).FirstOrDefaultAsync();
            troupe.employeess_id = tr.employeess_id;
            troupe.performancees_id = tr.performancees_id;
            troupe.role = tr.role;
            await _context.SaveChangesAsync();
        }
    }
}
