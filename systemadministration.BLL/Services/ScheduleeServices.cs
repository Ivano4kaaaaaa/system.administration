using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public  class ScheduleeServices
    {
        public ScheduleeServices()
        {

        }

        public Task<List<Schedule>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Schedule> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddCategorAsync(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}
