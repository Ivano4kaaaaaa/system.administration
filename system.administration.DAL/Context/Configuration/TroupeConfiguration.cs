using Microsoft.EntityFrameworkCore;
using system.administration.DAL.Entities;
using System;

namespace system.administration.DAL.Context.Configuration
{
    public class TroupeConfiguration : IEntityTypeConfiguration<Troupe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Troupe> builder)
        {
            builder.ToTable("Troupe");

            builder.HasKey(t => t.id);

            builder.Property(t => t.id)
                .HasColumnName("troupe_id")
                .UseIdentityColumn(); // Identity column for id

            builder.Property(t => t.performancees_id) // Correct the property name to "performances_id"
                .HasColumnName("troupe_performance_id")
                .ValueGeneratedNever(); // Assuming this is not an identity column

            builder.Property(t => t.employeess_id) // Correct the property name to "employees_id"
                .HasColumnName("troupe_employee_id")
                .ValueGeneratedNever(); // Assuming this is not an identity column

            builder.Property(t => t.role)
                .HasColumnName("troupe_role");
        }
    }
}
