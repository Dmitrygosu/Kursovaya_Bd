
using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Translator
    {
        [Key] 
        public int ID_Переводчика { get; set; }

        [Range(1, 5, ErrorMessage = "Рейтинг должен быть от 1 до 5.")]
        public int Рейтинг { get; set; }

        [Required(ErrorMessage = "Требуется поле Зарплата.")]
        public decimal Зарплата { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Дата_рождения { get; set; }
    }
}
