using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Creator : Empty
    {
        public string FullName { get; set; }
        public CreatorRole Role { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
