using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Требуется поле Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Требуется поле Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Требуется поле Password.")]
        public string Password { get; set; }

        public int Rating { get; set; }

        [Required(ErrorMessage = "Требуется поле FullName.")]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }
    }
}
