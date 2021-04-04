using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class ReviewRate: Empty
    {
        public string Category { get; set; }
        public double Rate { get; set; }
    }
}
