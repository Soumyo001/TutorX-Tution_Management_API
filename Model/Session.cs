using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Session
    {
        [Key]
        public int sessionId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        [Required]
        public string startDate { get; set; } = "";

        [Required]
        public string endDate { get; set; } = "";

        [Required]
        public string duration { get; set; } = "";

        [Required]
        public SessionStatus sessionStatus { get; set; }

        public Student student { get; set; }

        public Tutor tutor { get; set; }

        public Payment payment { get; set; }
    }
}
