using system.administration.DAL.Entities;
using system.administration.DAL.IRepository;
using system.administration.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public class TroupeeServices
    {
        private readonly ITroupeRepository _troupeRepository;
        public TroupeeServices(ITroupeRepository troupeRepository)
        {
            _troupeRepository = troupeRepository;
        }

        public TroupeeServices(){}

        public async Task<IEnumerable<Troupe>> GetAllTroupeAsync()
        {
            return await _troupeRepository.GetAllTroupeAsync();
        }

        public  async Task AddTroupeAsync(Troupe tr)
        {
            await _troupeRepository.AddTroupeAsync(tr);
        }

        public async Task DeleteTroupeAsync(Troupe tr)
        {
            await _troupeRepository.DeleteTroupeAsync(tr);
        }

        public async Task UpdateTroupeAsync(Troupe tr)
        {
            await _troupeRepository.UpdateTroupeAsync(tr);
        }
        public async Task<Troupe> GetTroupeByIdAsync(int id)
        {
            return await _troupeRepository.GetTroupeByIdAsync(id);
        }

        public async Task DeleteTroupeAsync(Task<Troupe> troupe)
        {
            throw new NotImplementedException();
        }
    }
}
