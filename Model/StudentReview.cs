using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class StudentReview
    {
        [Key]
        public int studentReviewId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        [Required]
        public int rating { get; set; } = 0;

        [Required]
        public string reviewText { get; set; } = "";

        [Required]
        public string reviewDate { get; set; } = "";

        public Student student { get; set; }

    }
}
