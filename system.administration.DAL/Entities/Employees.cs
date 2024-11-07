using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Entities
{
    public class Employees
    {
        public int id { get; set; }
        public string? surname { get; set; }
        public string? name { get; set; }
        public string? patronymic { get; set; }
        public int year_of_birth { get; set; }
        public int year_of_admission { get; set; }
        public int length_of_service { get; set; }
        public string? position { get; set; }
        public string? gender { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? phone_number { get; set; }
    }
}
