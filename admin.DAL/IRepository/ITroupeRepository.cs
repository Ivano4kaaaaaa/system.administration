using admin.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.IRepository
{
    public interface ITroupeRepository
    {
        public Task<IEnumerable<Troupe>> GetAllTroupeAsync();
        public Task AddTroupeAsync(Troupe tr);
        public Task DeleteTroupeAsync(Troupe tr);
        public Task UpdateTroupeAsync(Troupe tr);
        public Task<Troupe> GetTroupeByIdAsync(int id);
    }
}
