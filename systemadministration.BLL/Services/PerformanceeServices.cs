using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.administration.DAL.Entities;

namespace systemadministration.BLL.Services
{
    internal class PerformanceeServices
    {
        public PerformanceeServices()
        {

        }

        public Task<List<Performance>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Performance> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddCategorAsync(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategorAsync(Performance performance)
        {
            throw new NotImplementedException();
        }
    }
}
