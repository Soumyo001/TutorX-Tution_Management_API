using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class StudentPost
    {
        [Key]
        public int studentPostId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        public string fullName { get; set; } = "";

        public TutionDays days { get; set; }

        public string location { get; set; } = "";

        public string education { get; set; } = "";

        public string description { get; set; } = "";

        public StudentMedium studentMedium { get; set; } 

        public StudentTypes studentTypes { get; set; }

        public SubjectTypes subjectTypes { get; set; }

        public int salary { get; set; }
    }
}
