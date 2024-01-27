using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RatingId { get; set; }

        [Required(ErrorMessage = "Требуется поле Значение.")]
        public int Value { get; set; }

        [Required(ErrorMessage = "Требуется поле Имя оцениваемого переводчика.")]
        [StringLength(50, ErrorMessage = "Имя оцениваемого переводчика не может превышать 50 символов.")]
        public string TranslatorName { get; set; }
    }
}
