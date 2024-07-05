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

        public int rating { get; set; } = 0;

        public string reviewText { get; set; } = "";

 
        public string reviewDate { get; set; } = "";


    }
}
