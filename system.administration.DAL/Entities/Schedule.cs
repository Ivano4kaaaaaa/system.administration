using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Entities
{
    public  class Schedule
    {
        public int tour_id { get; set; }
        public int perfomance_id { get; set; }
        public DateTime start_data { get; set; }
        public DateTime end_data { get; set; }
        public string? venue { get; set; }
    }
}
