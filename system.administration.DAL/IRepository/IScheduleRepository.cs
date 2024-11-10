using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.IRepository
{
   public  interface IScheduleRepository
    {
        public Task<IEnumerable<Schedule>> GetAllScheduleAsync();
        public Task AddScheduleAsync(Schedule sch);
        public Task DeleteScheduleAsync(Schedule sch);
        public Task UpdateScheduleAsync(Schedule sch);
    }
}
