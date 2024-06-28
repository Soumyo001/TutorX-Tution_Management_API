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


        public int amount { get; set; }

    
        public string paymentDate { get; set; } = "";

     
        public PaymentMethod paymentMethod { get; set; }

        public PaymentStatus paymentStatus { get; set; }  

        public Session session { get; set; }
    }
}
