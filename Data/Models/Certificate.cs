using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Certificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateId { get; set; }

        [Required(ErrorMessage = "Требуется поле Название сертификата.")]
        [StringLength(32)]
        public string CertificateName { get; set; }

        [Required(ErrorMessage = "Требуется поле Организация выдавшая.")]
        [StringLength(32)]
        public string IssuingOrganization { get; set; }

        [Required(ErrorMessage = "Требуется поле Дата выдачи.")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage = "Требуется поле Дата истечения.")]
        [DataType(DataType.DateTime)]
        public DateTime ExpiryDate { get; set; }
    }
}
