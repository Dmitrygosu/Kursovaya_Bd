using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class CustomUser
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Требуется поле Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Требуется поле Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Требуется поле Password.")]
        public string Password { get; set; }
    }
}
