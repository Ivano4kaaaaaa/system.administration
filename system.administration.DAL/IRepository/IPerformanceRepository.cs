using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.IRepository
{
    public  interface IPerformanceRepository
    {
        public Task<IEnumerable<Performance>> GetAllPerformanceAsync();
        public Task AddPerformanceAsync(Performance perf);
        public Task DeletePerformanceAsync(Performance perf);
        public Task UpdatePerformanceAsync(Performance perf);
    }
}
