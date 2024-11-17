using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using system.administration.DAL.Entities;
using System;

namespace system.administration.DAL.Context.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedule");

            builder.HasKey(s => s.id);

            builder.Property(s => s.id)
                 .ValueGeneratedOnAdd();

            builder.Property(s => s.perfomancee_id) // Correct the property name to "performancee_id" if necessary
                .ValueGeneratedNever();

            builder.Property(s => s.startt_data) // Consider renaming to "start_date"
                .HasColumnName("schedule_start_date"); // Correct the column name here if needed

            builder.Property(s => s.end_data) // Consider renaming to "end_date"
                .HasColumnName("schedule_end_date"); // Correct the column name here if needed

            builder.Property(s => s.venue)
                .HasColumnName("schedule_venue");
        }
    }
}
