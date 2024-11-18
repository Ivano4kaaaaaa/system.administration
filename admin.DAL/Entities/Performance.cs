using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.DAL.Entities
{
    public class Performance
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? director { get; set; }
        public string? production_designer { get; set; }
        public string? conductor { get; set; }
        public string? authon { get; set; }
        public string? genre { get; set; }
        public string? type { get; set; }
    }
}
