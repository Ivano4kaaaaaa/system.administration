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
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
          
            builder.HasKey(e => e.id);

            builder.Property(e => e.id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.name);


            builder.Property(e => e.surname);


            builder.Property(e => e.patronymic);

            builder.Property(e => e.year_of_birth);

            builder.Property(e => e.year_of_admission);

            builder.Property(e => e.length_of_service);

            builder.Property(e => e.position);

            builder.Property(e => e.gender);

            builder.Property(e => e.address);

            builder.Property(e => e.city);

            builder.Property(e => e.phone_number);
             
        }
    }
}
