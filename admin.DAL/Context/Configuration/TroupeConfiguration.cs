using admin.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Context.Configuration
{
    public  class TroupeConfiguration : IEntityTypeConfiguration<Troupe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Troupe> builder)
        {
            

            builder.HasKey(t => t.id);

            builder.Property(t => t.id)
                .ValueGeneratedOnAdd();


            builder.Property(t => t.performancees_id);


            builder.Property(t => t.employeess_id);


            builder.Property(t => t.role);
        }
    }
}
