﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.administration.DAL.Entities
{
    public  class Performance
    {
        public int performance_id { get; set; }
        public string? name { get; set; }
        public string? director { get; set; }
        public string? artist { get; set; }
        public string? conductor { get; set; }
        public string? authon { get; set; }
        public string? genre { get; set; }
        public string? type { get; set; }   
    }
}