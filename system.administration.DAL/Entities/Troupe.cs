using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Entities
{
    public class Troupe
    {
        public int troupe_id { get; set; }
        public int performance_id { get; set; }
        public int employee_id { get; set; }
        public string? role { get; set; }

    }
}
