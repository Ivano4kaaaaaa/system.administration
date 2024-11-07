using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;

namespace systemadministration.BLL.Services
{
    public class PerformanceeServices
    {
        private static List<Performance> performancee = new List<Performance>();
        public PerformanceeServices()
        {
        }

        public Task<List<Performance>> GetPerformanceeAsync()
        {
           return Task.FromResult(performancee);
        }

        public Task<Performance> GetPerformanceByIdAsync(int performance_id)
        {
            throw new NotImplementedException();
        }

        public Task AddPerformanceAsync(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerformance(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task DeletePerformanceAsync(Performance performance)
        {
            throw new NotImplementedException();
        }
    }

}

