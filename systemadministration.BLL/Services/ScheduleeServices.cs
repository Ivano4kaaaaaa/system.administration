using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using system.administration.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemadministration.BLL.Services;

namespace systemadministration.BLL.Services
{
    public  class ScheduleeServices
    {
     private readonly IScheduleRepository _scheduleRepository;
        public ScheduleeServices(IScheduleRepository scheduleRepository)
        {
           _scheduleRepository = scheduleRepository;
            }
            public ScheduleeServices(){ }

        public async Task<IEnumerable<Schedule>> GetAllScheduleAsync()
        {
            return await _scheduleRepository.GetAllScheduleAsync();
        }

        public async Task DeleteScheduleAsync(Schedule sch)
        {
           await _scheduleRepository.DeleteScheduleAsync(sch);
        }

        public async Task AddScheduleAsync(Schedule sch)
        {
          await _scheduleRepository.AddScheduleAsync(sch);
        }

        public async Task UpdateScheduleAsync(Schedule sch)
        {
            await _scheduleRepository.UpdateScheduleAsync(sch);
        }
    }
}
