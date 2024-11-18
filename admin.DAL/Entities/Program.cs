using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Entities
{
    public class Program
    {
        public int id { get; set; }
        public string? show { get; set; }
        public DateTime premiere_data { get; set; }
        public string? performance_period { get; set; }
        public string? days_and_times { get; set; }
        public int ticket_price { get; set; }
    }
}
