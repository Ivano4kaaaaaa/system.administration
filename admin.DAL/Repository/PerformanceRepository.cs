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
    public class PerformanceRepository : IPerformanceRepository
    {
        private readonly SystemContextcs _contextcs;

        public PerformanceRepository()
        {
        }

        public PerformanceRepository(SystemContextcs contextcs)
        {
            _contextcs = contextcs;
        }

        public async Task AddPerformanceAsync(Performance perf)
        {

            _contextcs.Performances.AddAsync(perf);
            await _contextcs.SaveChangesAsync();
        }

        public async Task DeletePerformanceAsync(Performance perf)
        {
            var performance = await _contextcs.Performances.Where(p => p.id == perf.id).FirstOrDefaultAsync();
            _contextcs.Performances.Remove(performance);
            await _contextcs.SaveChangesAsync();
        }
        public async Task<IEnumerable<Performance>> GetAllPerformanceAsync()
        {
            return await _contextcs.Performances.ToListAsync();
        }

        public async Task<Performance> GetPerformanceAsync(int id)
        {
            return await _contextcs.Performances.Where(p => p.id == id).FirstAsync();
        }

        public async Task UpdatePerformanceAsync(Performance perf)
        {
            var performance = await _contextcs.Performances.Where(p => p.id == perf.id).FirstOrDefaultAsync();
            performance.director = perf.director;
            performance.conductor = perf.conductor;
            performance.genre = perf.genre;
            performance.name = perf.name;
            performance.production_designer = perf.production_designer;
            performance.type = perf.type;
            performance.authon = perf.authon;
            await _contextcs.SaveChangesAsync();
        }
    }
}
