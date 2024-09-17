using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class Messege
    {
        [Key]
        public string messegeId { get; set; } = "";

        [ForeignKey("User")]
        public int uidFrom { get; set; }

        [ForeignKey("User")]
        public int uidTo { get; set; }


        public string messegeText { get; set; } = "";

        public DateTime timeStamp { get; set; } = DateTime.Now;
    }
}
