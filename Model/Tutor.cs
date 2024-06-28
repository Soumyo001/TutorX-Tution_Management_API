using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Tutor
    {
        [Key]
        public int tutorId { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }


        public AvailabilityStatus status { get; set; }


        public StudentMedium mediumOfInterest { get; set; }


        public StudentTypes expectedStudent { get; set; }

        public SubjectTypes subjectOfInterest { get; set; }

        public int expectedSalary { get; set; }


        public ProfessionType profession { get; set; }

        public VerificationStatus verificationStatus { get; set; }

        public string tutorSelfDescription { get; set; } = "";

        public BackgroundChecks backgroundChecks { get; set; }

        public ICollection<Session> sessions { get; set;}

        public ICollection<Request> requests { get; set; }

        public ICollection<Report> reports { get; set; }

        public ICollection<Messege> messeges { get; set; }
    }
}
