using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class BackgroundChecks
    {
        [Key]
        public int checkId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        [Required]
        public TutorBackgroundCheckType backgroundCheckedType { get; set; }

        [Required]
        public DateTime checkedDate { get; set; }

        [Required]
        public VerificationStatus result {  get; set; }

        public Tutor Tutor { get; set; }
    }
}
