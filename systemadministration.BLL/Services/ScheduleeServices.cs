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

        public async Task<IEnumerable<Schedule>> GetAllScheduleAsync()
        {
            return await _scheduleRepository.GetAllScheduleAsync();
        }

        public async Task DeleteScheduleAsync(int id)
        {
            var schedule = await _scheduleRepository.GetSheduleByIdAsync(id);
            if (schedule != null)
            {
                await _scheduleRepository.DeleteScheduleAsync(schedule);
            }
            else
            {
                throw new Exception("Програму не знайдено");
            }
        }

        public async Task AddScheduleAsync(Schedule sch)
        {
          await _scheduleRepository.AddScheduleAsync(sch);
        }

        public async Task UpdateScheduleAsync(int id)
        {
            var schedule = await _scheduleRepository.GetSheduleByIdAsync(id);
            if (schedule != null)
            {
                await _scheduleRepository.UpdateScheduleAsync(schedule);
            }
            else
            {
                throw new Exception("Програму оновлено");
            }
        }
        public async Task<Schedule> GetScheduleByIdAsync(int id)
        {
            return await _scheduleRepository.GetSheduleByIdAsync(id);
        }
    }
}
