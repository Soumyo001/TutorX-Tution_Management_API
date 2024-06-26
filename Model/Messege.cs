using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class Messege
    {
        [Key]
        public string messegeId { get; set; } = "";

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }

        [Required]
        public string messege { get; set; } = "";

        [Required]
        public DateTime timeStamp { get; set; } = DateTime.Now;
        
        public Student student { get; set; }

        public Tutor tutor { get; set; }
    }
}
