using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public enum ActorRole
    {
        [Display(Name = "Главная роль")] Main,
        [Display(Name = "Второстепенная роль")] Minor,
    }
}
