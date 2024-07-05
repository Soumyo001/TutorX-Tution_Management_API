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


        public string messegeText { get; set; } = "";

        public DateTime timeStamp { get; set; } = DateTime.Now;
    }
}
