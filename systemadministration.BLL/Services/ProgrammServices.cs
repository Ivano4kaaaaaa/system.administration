using admin.DAL.Entities;
using admin.DAL.IRepository;
using admin.DAL.Repository;
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

        public async Task UpdateProgramAsync(int id)
        {
            var program = await _programRepository.GetProgramAsync(id);
            if (program != null)
            {
                await _programRepository.UpdateProgramAsync(program);
            }
            else
            {
                throw new Exception("Програму оновлено");
            }
    }
        public async Task DeleteProgramAsync(int id)
        {
            var program = await _programRepository.GetProgramAsync(id);
            if (program != null)
            {
                await _programRepository.DeleteProgramAsync(program);
            }
            else
            {
                throw new Exception("Програму не знайдено");
            }
        }
        public async Task<Program> GetProgramByIdAsync(int id)
        {
            return await _programRepository.GetProgramAsync(id);
        }

    }
 }
