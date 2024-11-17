using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Context.Configuration
{
    public class PerformanceConfiguration : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            builder.ToTable("Performance");

            builder.HasKey(p => p.id);

            builder.Property(p => p.id)
                .HasColumnName("performance_id")
                .UseIdentityColumn();

            builder.Property(p => p.name)
                .HasColumnName("performance_name");
            builder.Property(p => p.director)
                .HasColumnName("performance_director");
            builder.Property(p => p.production_designer)
                .HasColumnName("performance_production_designer");
            builder.Property(p => p.conductor)
                .HasColumnName("performance_conductor");
            builder.Property(p => p.authon)
                .HasColumnName("performance_authon");
            builder.Property(p => p.genre)
                .HasColumnName("performance_gender");
            builder.Property(p => p.type)
                .HasColumnName("performance_type");
        }
    }
}
