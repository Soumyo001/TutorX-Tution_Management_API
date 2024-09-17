using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class TutorPost
    {
        [Key]
        public int tutorPostId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        public string fullName { get; set; } = "";

        public string bio { get; set; } = "";

        public string location { get; set; } = "";

        public string description { get; set; } = "";

        public SubjectTypes subjectTypes { get; set; }

        public StudentMedium studentMedium { get; set; }

        public StudentTypes studentTypes { get; set; }
    }
}
