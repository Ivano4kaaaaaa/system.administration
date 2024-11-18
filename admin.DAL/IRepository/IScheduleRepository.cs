using admin.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.IRepository
{
    public interface IScheduleRepository
    {
        public Task<IEnumerable<Schedule>> GetAllScheduleAsync();
        public Task AddScheduleAsync(Schedule sch);
        public Task DeleteScheduleAsync(Schedule sch);
        public Task UpdateScheduleAsync(Schedule sch);
        public Task<Schedule> GetSheduleByIdAsync(int id);

    }
}
