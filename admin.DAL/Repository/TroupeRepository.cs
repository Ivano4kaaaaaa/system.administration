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
    public  class TroupeRepository : ITroupeRepository
    {
        private readonly SystemContextcs  _contextcs;
        public TroupeRepository(SystemContextcs contextcs)
        {
            _contextcs = contextcs;
        }
        public async Task AddTroupeAsync(Troupe tr)
        {
            var troupe = await _contextcs.Troupes.Where(t => t.id == tr.id).FirstOrDefaultAsync();
            troupe.id = tr.id;
            troupe.employeess_id = tr.employeess_id;
            troupe.performancees_id = tr.performancees_id;
            troupe.role = tr.role;
            await _contextcs.SaveChangesAsync();
        }

        public async Task DeleteTroupeAsync(Troupe tr)
        {
            var troupe = await _contextcs.Troupes.Where(t => t.id == tr.id).FirstOrDefaultAsync();
            _contextcs.Troupes.Remove(troupe);
            await _contextcs.SaveChangesAsync();

        }

        public async Task<IEnumerable<Troupe>> GetAllTroupeAsync()
        {
            return await _contextcs.Troupes.ToListAsync();
        }

        public async Task<Troupe> GetTroupeByIdAsync(int id)
        {
            return await _contextcs.Troupes.Where(t => t.id == id).FirstAsync();
        }

        public async Task UpdateTroupeAsync(Troupe tr)
        {
            var troupe = await _contextcs.Troupes.Where(t => t.id == tr.id).FirstOrDefaultAsync();
            troupe.employeess_id = tr.employeess_id;
            troupe.performancees_id = tr.performancees_id;
            troupe.role = tr.role;
            await _contextcs.SaveChangesAsync();
        }
    }
}

