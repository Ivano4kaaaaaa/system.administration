using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Context;
using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using system.administration.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Repository
{
    public class ProgramRepository : IProgramRepository
    { 
    private readonly SystemContext _context;
    public ProgramRepository(SystemContext context)
    {
        _context = context;
    }

        public async Task AddProgramAsync(Program prog)
        {
            _context.Programs.AddAsync(prog);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProgramAsync(Program prog)
        {
           var program = await _context.Programs.Where(pr=> pr.id == prog.id).FirstOrDefaultAsync();
            _context.Programs.Remove(program);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Program>> GetAllProgramAsync()
        {
            return await _context.Programs.ToListAsync();
        }

        public async Task<Program> GetProgramAsync(int id)
        {
            return await _context.Programs.Where(p => p.id == id).FirstAsync();
        }

        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _context.Programs.Where(pr => pr.id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateProgramAsync(Program prog)
        {
            var program = await _context.Programs.Where(pr => pr.id == prog.id).FirstOrDefaultAsync();
            program.show = prog.show;
            program.premiere_data = prog.premiere_data;
            program.ticket_price = prog.ticket_price;
            program.days_and_times = prog.days_and_times;
            program.performance_period = prog.performance_period;
            await _context.SaveChangesAsync();
        }
    }
}

