using admin.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Context
{
    public class SystemContextcs : DbContext
    {
        public SystemContextcs(DbContextOptions<SystemContextcs> options) : base(options)
        { }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Troupe> Troupes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
