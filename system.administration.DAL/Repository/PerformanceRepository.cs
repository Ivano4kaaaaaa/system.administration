using system.administration.DAL.Context;
using system.administration.DAL.IRepository;
using system.administration.DAL.Context;
using system.administration.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace system.administration.DAL.Repository
{
     public class  PerformanceRepository : IPerformanceRepository
    {
        private readonly  SystemContext _context;
        public PerformanceRepository(SystemContext context)
        {
            _context = context;
        }

        public async Task AddPerformanceAsync(Performance perf)
        {

            _context.Performances.AddAsync(perf);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePerformanceAsync(Performance perf)
        {
            var performance = await _context.Performances.Where(p => p.id == perf.id).FirstOrDefaultAsync();
            _context.Performances.Remove(performance);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Performance>> GetAllPerformanceAsync()
        {
            return await _context.Performances.ToListAsync();
        }

        public async Task<Performance> GetPerformanceAsync(int id)
        {
            return await _context.Performances.Where(p => p.id == id).FirstAsync();
        }

        public async Task UpdatePerformanceAsync(Performance perf)
        {
            var performance = await _context.Performances.Where(p => p.id == perf.id).FirstOrDefaultAsync();
            performance.director= perf.director;
            performance.conductor= perf.conductor;
            performance.genre= perf.genre;
            performance.name= perf.name;
            performance.production_designer= perf.production_designer;
            performance.type= perf.type;
            performance.authon= perf.authon;
            await _context.SaveChangesAsync();
        }

        Task<Employees> IPerformanceRepository.GetPerformanceAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
