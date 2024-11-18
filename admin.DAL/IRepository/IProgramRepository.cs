﻿using admin.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.IRepository
{
    public interface IProgramRepository
    {
        public Task<IEnumerable<Program>> GetAllProgramAsync();
        public Task AddProgramAsync(Program prog);
        public Task DeleteProgramAsync(Program prog);
        public Task UpdateProgramAsync(Program prog);
        public Task<Program> GetProgramAsync(int id);
    }
}