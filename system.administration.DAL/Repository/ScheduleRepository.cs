﻿using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Context;
using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace system.administration.DAL.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly SystemContext _context;
        public ScheduleRepository(SystemContext context)
        {
            _context = context;
        }
        public async Task AddScheduleAsync(Schedule sch)
        {
            var schedule = await _context.Schedules.Where(s=> s.id == sch.id).FirstOrDefaultAsync();
            schedule.id = sch.id;
            schedule.perfomancee_id = sch.perfomancee_id;
            schedule.startt_data = sch.startt_data;
            schedule.end_data = sch.end_data;
            schedule.venue= sch.venue;
            await _context.SaveChangesAsync();
    }

        public async Task DeleteScheduleAsync(Schedule sch)
        {
            var schedule = await _context.Schedules.Where(s => s.id == sch.id).FirstOrDefaultAsync();
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Schedule>> GetAllScheduleAsync()
        {
            return await _context.Schedules.ToListAsync();
        }

        public async Task<Schedule> GetSheduleByIdAsync(int id)
        {
            return await _context.Schedules.Where(sh => sh.id == id ).FirstAsync();
           
        }

        public async Task UpdateScheduleAsync(Schedule sch)
        {
            var schedule = await _context.Schedules.Where(s => s.id == sch.id).FirstOrDefaultAsync();
            schedule.perfomancee_id = sch.perfomancee_id;
            schedule.startt_data = sch.startt_data;
            schedule.end_data = sch.end_data;
            schedule.venue = sch.venue;
            await _context.SaveChangesAsync();
        }
    }
}
