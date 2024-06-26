using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }

        [Required]
        public string firstName { get; set; } = "";

        [Required]
        public string lastName { get; set; } = "";

        [Required]
        public StudentMedium StudentMedium { get; set; }

        public string studentSelfDescription { get; set; } = "";

        public Session session { get; set; }

        public ICollection<Request> requests { get; set; }

        public ICollection<StudentReview> studentReviews { get; set; }

        public ICollection<Report> reports { get; set; }

        public ICollection<Messege> messeges { get; set; }
    }
}
