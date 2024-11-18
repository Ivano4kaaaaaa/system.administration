using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Entities
{
    public class Schedule
    {
        public int id { get; set; }
        public int perfomancee_id { get; set; }
        public DateTime startt_data { get; set; }
        public DateTime end_data { get; set; }
        public string? venue { get; set; }
    }
}
