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
    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
           

            builder.HasKey(pr => pr.id);

            builder.Property(pr => pr.id)
                .ValueGeneratedOnAdd();

            builder.Property(pr => pr.show);

            builder.Property(pr => pr.premiere_data);

            builder.Property(pr => pr.performance_period);

            builder.Property(pr => pr.days_and_times);

            builder.Property(pr => pr.ticket_price);
                
        }
    }
}
