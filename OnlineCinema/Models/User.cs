using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public class User:Empty
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Subscribe Subscribe { get; set; }
        public bool IsAdmin { get; set; }
    }
}
