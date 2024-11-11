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
    public class ProgrammServices
    {
        private readonly IProgramRepository _programRepository;
        public ProgrammServices (IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }
       
        public async Task<IEnumerable<Program>> GetAllProgramAsync()
        {
            return await _programRepository.GetAllProgramAsync() ;
        }
        public async Task AddProgramAsync(Program prog)
        {
           await _programRepository.AddProgramAsync(prog);
        }

        public Task UpdateProgramAsync(Program prog)
        {
          return _programRepository.UpdateProgramAsync(prog);   
        }
        public async Task DeleteProgramAsync(Program prog)
        {
           await _programRepository.DeleteProgramAsync(prog);
        }
        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _programRepository.GetProgramAsync(id);
        }

    }
 }

