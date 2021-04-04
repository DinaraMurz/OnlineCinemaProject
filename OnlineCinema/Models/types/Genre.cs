using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema.Models
{
    public enum Genre  
    { 
        [Display(Name ="Боевик")] Action,
        [Display(Name = "Комедия")] Comedy,
        [Display(Name = "Драма")] Drama,
        [Display(Name = "Фентези")] Fantasy,
        [Display(Name = "Хоррор")] Horror,
        [Display(Name = "Мистика")] Mystery,
        [Display(Name = "Романтика")] Romance,
        [Display(Name = "Триллер")] Thriller,
        [Display(Name = "Вестрн")] Western,
        [Display(Name = "Преключение")] Adventure,
        [Display(Name = "Мультфильм")] Cartoon,
        [Display(Name = "Фниме")] Anime,
        [Display(Name = "Биографический")] Biography,
        [Display(Name = "Криминал")] Crime,
        [Display(Name = "Мюзикал")] Musical,
        [Display(Name = "Спорт")] Sport,
        [Display(Name = "Война")] War,
        [Display(Name = "Путешествие во Времени")] TimeAdventure,
    }
}
