using admin.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Context.Configuration
{
    public class PerformanceConfiguration : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            builder.HasKey(p => p.id);

            builder.Property(p => p.id)
                   .ValueGeneratedOnAdd();


            builder.Property(p => p.name);

            builder.Property(p => p.director);

            builder.Property(p => p.production_designer);

            builder.Property(p => p.conductor);

            builder.Property(p => p.authon);

            builder.Property(p => p.genre);

            builder.Property(p => p.type);
                
        }
    }
}
