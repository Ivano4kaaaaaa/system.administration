using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public class ProgrammServices
    {
        public ProgrammServices()
        {

        }
        private static List<Program> programs = new List<Program>();
        public Task<List<Program>> GetProgramAsync()
        {
            return Task.FromResult(programs);
        }

        public Task<Program> GetProgramByIdAsync(string show)
        {
            var program = programs.Find(p => p.show == show); 
            return Task.FromResult(program);
        }

        public Task AddProgramAsync(Program program)
        {
            programs.Add(program);
            return Task.CompletedTask;
        }

        public Task UpdateProgramAsync(Program program)
        {
            var existingProgram = programs.Find(p => p.show == program.show);
            if (existingProgram != null)
            {
                existingProgram.show = program.show;
                existingProgram.ticket_price = program.ticket_price;
                existingProgram.days_and_times = program.days_and_times;
                existingProgram.premiere_data = program.premiere_data;
                existingProgram.performance_period = program.performance_period;
            }
            return Task.CompletedTask;
        }
        public Task DeleteProgramAsync(Program program)
        {
            programs.Remove(program); 
            return Task.CompletedTask;
        }
    }
 }
    
      




