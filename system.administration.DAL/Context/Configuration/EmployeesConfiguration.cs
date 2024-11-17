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
    public class EmployeesConfiguration:IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(e => e.id);

            builder.Property(e => e.id)
                .HasColumnName("employees_id")
                .UseIdentityColumn();

            builder.Property(e => e.name)
                .HasColumnName("employees_name");

            builder.Property(e => e.surname)
                .HasColumnName("employees_surname");

            builder.Property(e => e.patronymic)
              .HasColumnName("employees_patronymic");
            builder.Property(e => e.year_of_birth)
              .HasColumnName("employees_year_of_birth");
            builder.Property(e => e.year_of_admission)
              .HasColumnName("employees_year_of_admission");
            builder.Property(e => e.length_of_service)
              .HasColumnName("employees_length_of_service");
            builder.Property(e => e.position)
              .HasColumnName("employees_position");
            builder.Property(e => e.gender)
             .HasColumnName("employees_gender");
            builder.Property(e => e.address)
             .HasColumnName("employees_address");
            builder.Property(e => e.city)
             .HasColumnName("employees_city");
            builder.Property(e => e.phone_number)
             .HasColumnName("employees_phone_number");
        }
    }
}
