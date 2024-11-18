using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Entities
{
    public class Troupe
    {
        public int id { get; set; }
        public int performancees_id { get; set; }
        public int employeess_id { get; set; }
        public string? role { get; set; }
    }
}
