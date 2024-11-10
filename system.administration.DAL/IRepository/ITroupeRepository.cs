﻿using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.IRepository
{
    public interface ITroupeRepository
    {
        public Task<IEnumerable<Troupe>> GetAllTroupeAsync();
        public Task AddTroupeAsync(Troupe tr);
        public Task DeleteTroupeAsync(Troupe tr);
        public Task UpdateTroupeAsync(Troupe tr);
    }
}