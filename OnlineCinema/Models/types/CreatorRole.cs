using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public enum CreatorRole
    {
        [Display(Name = "Режиссер")] Producer,
        [Display(Name = "Сценарист")] Scenarist,
    }
}
