using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Context.Configuration
{
    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.ToTable("Program");

            builder.HasKey(pr => pr.id);

            builder.Property(pr => pr.id)
                .HasColumnName("program_id")
                .UseIdentityColumn();

            builder.Property(pr => pr.show)
                .HasColumnName("program_show");
            builder.Property(pr => pr.premiere_data)
                .HasColumnName("program_premiere_data");
            builder.Property(pr => pr.performance_period)
                .HasColumnName("program_performance_period");
            builder.Property(pr => pr.days_and_times)
                .HasColumnName("program_days_and_times");
            builder.Property(pr => pr.ticket_price)
                .HasColumnName("program_ticket_price");
        }
    }
}
