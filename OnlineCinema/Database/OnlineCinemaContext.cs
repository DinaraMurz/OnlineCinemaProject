using Microsoft.EntityFrameworkCore;
using OnlineCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.DataBase
{
    public class OnlineCinemaContext : DbContext
    {
        public OnlineCinemaContext(DbContextOptions<OnlineCinemaContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }



    }
}
