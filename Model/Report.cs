using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class Report
    {
        [Key]
        public int reportId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        public string reportText { get; set; } = "";

        public string reportDate { get; set; } = "";

        public Student student { get; set; }

        public Tutor tutor { get; set; }
    }
}
