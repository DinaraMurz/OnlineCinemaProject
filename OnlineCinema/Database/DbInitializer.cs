using OnlineCinema.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Database
{
    public static class DbInitializer
    {
        public static void Initialize(OnlineCinemaContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
