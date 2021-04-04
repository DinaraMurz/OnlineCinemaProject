using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class Movie : Empty
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Info { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public Rate Rate { get; set; }
        public double Price { get; set; }
        public bool IsForSubsriber { get; set; }
        public string MovieAddress { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
