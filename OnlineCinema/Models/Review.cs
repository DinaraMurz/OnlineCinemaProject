using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Review : Empty
    {
        public User User { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public ICollection<ReviewRate> ReviewRates { get; set; }

    }
}
