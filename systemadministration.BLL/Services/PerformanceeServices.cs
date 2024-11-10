using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;
using system.administration.DAL.IRepository;
using system.administration.DAL.Repository;


namespace systemadministration.BLL.Services
{
  
    public class PerformanceeServices
    {
        private readonly IPerformanceRepository _performanceRepository;
        public PerformanceeServices(IPerformanceRepository performanceRepository)
        {
            _performanceRepository = performanceRepository;
        }

        public async Task<IEnumerable<Performance>> GetAllPerformanceAsync()
        {
            return  await _performanceRepository.GetAllPerformanceAsync();

        }

        public async Task AddPerformanceAsync(Performance perf)
        {
             await _performanceRepository.AddPerformanceAsync(perf);
        }

        public async Task UpdatePerformance(Performance perf)
        {
           await _performanceRepository.UpdatePerformanceAsync(perf);  
        }

        public async Task DeletePerformanceAsync(Performance perf)
        {
          await _performanceRepository.DeletePerformanceAsync(perf);
        }
    }

}

