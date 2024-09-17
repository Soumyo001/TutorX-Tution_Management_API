using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Request
    {
        [Key]
        public int requestId { get; set; }

        [ForeignKey("User")]
        public int uidFrom { get; set; }

        [ForeignKey("User")]
        public int uidTo { get; set; }

        public string requestDate { get; set; } = "";

        public bool isFromTutor { get; set; }

        public RequestStatus status { get; set; } = RequestStatus.pending;

    }
}
