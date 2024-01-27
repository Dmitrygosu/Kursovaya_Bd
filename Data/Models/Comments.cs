using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле Текст.")]
        public string Text { get; set; }
    }
}
