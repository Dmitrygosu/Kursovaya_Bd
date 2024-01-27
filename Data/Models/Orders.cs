using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Требуется поле SourceLanguage.")]
        public string SourceLanguage { get; set; }

        [Required(ErrorMessage = "Требуется поле FinalLanguage.")]
        public string FinalLanguage { get; set; }

        public bool Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Требуется поле OrderCost.")]
        public decimal OrderCost { get; set; }
    }
}
