using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentTypeId { get; set; }

        [Required(ErrorMessage = "Поле 'Название платежной системы' обязательно для заполнения.")]
        [StringLength(32, ErrorMessage = "Длина поля 'Название платежной системы' не должна превышать 32 символа.")]
        public string PaymentName { get; set; }

        [Required(ErrorMessage = "Поле 'Статус платежа' обязательно для заполнения.")]
        public bool PaymentStatus { get; set; }
    }
}
