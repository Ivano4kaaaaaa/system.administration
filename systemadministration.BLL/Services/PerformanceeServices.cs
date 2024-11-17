using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using system.administration.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public async Task UpdatePerformance(int id)
        {
           var performances = await _performanceRepository.GetPerformanceAsync(id);
            if (performances != null)
            {
                await _performanceRepository.UpdatePerformanceAsync(performances);
            }else
            {
                throw new Exception("Виставу оновлено");
            }
        }

        public async Task DeletePerformanceAsync(int id)
        {
            var performances = await _performanceRepository.GetPerformanceAsync(id);
            if (performances != null)
            {
                await _performanceRepository.DeletePerformanceAsync(performances);
            }else{
                throw new Exception("Виставу не знайдено");
            }
        }
        public async Task<Performance> GetPerformanceByIdAsync(int id)
        {
            return await _performanceRepository.GetPerformanceAsync(id);
        }
    }

}
