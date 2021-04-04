 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models.RelationShips
{
    public class ActorMovie:Empty
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
    }
}
