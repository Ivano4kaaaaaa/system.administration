using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Context
{
    public class SystemContext : DbContext
    {
        public SystemContext()
        { }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Troupe> Troupes { get; set; }
    }
}
