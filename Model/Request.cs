using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Request
    {
        [Key]
        public int requestId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        public string requestDate { get; set; } = "";

        public bool isFromTutor { get; set; }

        public RequestStatus status { get; set; }

        public Student student { get; set; }

        public Tutor tutor { get; set; }
    }
}
