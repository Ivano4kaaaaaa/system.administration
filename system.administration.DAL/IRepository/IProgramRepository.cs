using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.IRepository
{
    public interface IProgramRepository
    {
        public Task<IEnumerable<Program>> GetAllProgramAsync();
        public Task AddProgramAsync(Program prog);
        public Task DeleteProgramAsync(Program prog);
        public Task UpdateProgramAsync(Program prog);
    }
}
