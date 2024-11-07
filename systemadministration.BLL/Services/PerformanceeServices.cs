using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.administration.DAL.Entities;
using systemadministration.BLL.Services;

namespace systemadministration.BLL.Services
{
    public class PerformanceeServices
    {
        private static List<Performance> performancee = new List<Performance>();
        public PerformanceeServices()
        {
        }

        public Task<List<Performance>> GetPerformanceeAsync()
        {
           return Task.FromResult(performancee);
        }

        public Task<Performance> GetPerformanceByIdAsync(int performance_id)
        {
            var performancee = performance_id.Find(pr => pr. == show);
            return Task.FromResult(program);
        }

        public Task AddPerformanceAsync(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerformance(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task DeletePerformanceAsync(Performance performance)
        {
            throw new NotImplementedException();
        }
    }

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