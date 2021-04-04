using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Actor:Empty
    {
        public string FullName { get; set; }
        public ActorRole Role { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
