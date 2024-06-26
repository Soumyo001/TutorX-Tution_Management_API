using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Payment
    {
        [Key]
        public int paymentId { get; set; }

        [ForeignKey("Session")]
        public int sessionId { get; set; }

        [Required]
        public int amount { get; set; }

        [Required]
        public string paymentDate { get; set; } = "";

        [Required]
        public PaymentMethod paymentMethod { get; set; }

        [Required]
        public PaymentStatus paymentStatus { get; set; }  

        public Session session { get; set; }
    }
}
