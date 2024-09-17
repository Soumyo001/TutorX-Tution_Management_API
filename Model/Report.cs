using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class Report
    {
        [Key]
        public int reportId { get; set; }

        [ForeignKey("User")]
        public int uidFrom { get; set; }

        [ForeignKey("User")]
        public int uidTo { get; set; }

        public string reportText { get; set; } = "";

        public string reportDate { get; set; } = "";

    }
}
