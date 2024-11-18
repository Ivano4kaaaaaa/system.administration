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
    public class ProgramRepository : IProgramRepository
    {
        private readonly SystemContextcs _contextcs;
        public ProgramRepository(SystemContextcs contextcs)
        {
            _contextcs = contextcs;
        }

        public async Task AddProgramAsync(Program prog)
        {
            _contextcs.Programs.AddAsync(prog);
            await _contextcs.SaveChangesAsync();
        }

        public async Task DeleteProgramAsync(Program prog)
        {
            var program = await _contextcs.Programs.Where(pr => pr.id == prog.id).FirstOrDefaultAsync();
            _contextcs.Programs.Remove(program);
            await _contextcs.SaveChangesAsync();
        }

        public async Task<IEnumerable<Program>> GetAllProgramAsync()
        {
            return await _contextcs.Programs.ToListAsync();
        }

        public async Task<Program> GetProgramAsync(int id)
        {
            return await _contextcs.Programs.Where(p => p.id == id).FirstAsync();
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _contextcs.Programs.Where(pr => pr.id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateProgramAsync(Program prog)
        {
            var program = await _contextcs.Programs.Where(pr => pr.id == prog.id).FirstOrDefaultAsync();
            program.show = prog.show;
            program.premiere_data = prog.premiere_data;
            program.ticket_price = prog.ticket_price;
            program.days_and_times = prog.days_and_times;
            program.performance_period = prog.performance_period;
            await _contextcs.SaveChangesAsync();
        }
    }
}
