using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public enum SubscribeType
    {
        [Display(Name = "Стандартная")] General,
        [Display(Name = "VIP")] VIP,
    }
}
