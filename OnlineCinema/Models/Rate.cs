using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Rate: Empty
    {
        private int RateNumber = 5;
        public int NumberOfFives { get; set; }
        public int NumberOfFours { get; set; }
        public int NumberOfThrees { get; set; }
        public int NumberOfTwos { get; set; }
        public int NumberOfOnes { get; set; }

        public double GetAverageRate()
        {
            double average = 5 * NumberOfFives + 4 * NumberOfFours + 3 * NumberOfThrees + 2 * NumberOfTwos + 1 * NumberOfOnes;
            average = average / RateNumber;
            return average;
        }

    }
}
