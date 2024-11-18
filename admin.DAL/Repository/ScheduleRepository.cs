using admin.DAL.Context;
using admin.DAL.Entities;
using admin.DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {

        private readonly SystemContextcs _contextcs;
        public ScheduleRepository(SystemContextcs contextcs)
        {
            _contextcs = contextcs;
        }
        public async Task AddScheduleAsync(Schedule sch)
        {
            var schedule = await _contextcs.Schedules.Where(s => s.id == sch.id).FirstOrDefaultAsync();
            schedule.id = sch.id;
            schedule.perfomancee_id = sch.perfomancee_id;
            schedule.startt_data = sch.startt_data;
            schedule.end_data = sch.end_data;
            schedule.venue = sch.venue;
            await _contextcs.SaveChangesAsync();
        }

        public async Task DeleteScheduleAsync(Schedule sch)
        {
            var schedule = await _contextcs.Schedules.Where(s => s.id == sch.id).FirstOrDefaultAsync();
            _contextcs.Schedules.Remove(schedule);
            await _contextcs.SaveChangesAsync();
        }

        public async Task<IEnumerable<Schedule>> GetAllScheduleAsync()
        {
            return await _contextcs.Schedules.ToListAsync();
        }

        public async Task<Schedule> GetSheduleByIdAsync(int id)
        {
            return await _contextcs.Schedules.Where(sh => sh.id == id).FirstAsync();

        }

        public async Task UpdateScheduleAsync(Schedule sch)
        {
            var schedule = await _contextcs.Schedules.Where(s => s.id == sch.id).FirstOrDefaultAsync();
            schedule.perfomancee_id = sch.perfomancee_id;
            schedule.startt_data = sch.startt_data;
            schedule.end_data = sch.end_data;
            schedule.venue = sch.venue;
            await _contextcs.SaveChangesAsync();
        }
    }
}

