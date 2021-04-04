using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Subscribe
    {
        public SubscribeType SubscribeType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan Latitude { get; set; }
        public double PriceInTenge { get; set; }
    }
}
