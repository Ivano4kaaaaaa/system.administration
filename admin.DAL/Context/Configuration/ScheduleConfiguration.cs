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
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
           

            builder.HasKey(s => s.id);

            builder.Property(s => s.id)
                 .ValueGeneratedOnAdd();

            builder.Property(s => s.perfomancee_id); 
                

            builder.Property(s => s.startt_data); 


            builder.Property(s => s.end_data); 


            builder.Property(s => s.venue);
                
        }
    }
}
