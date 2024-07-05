using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutor_X_Tution_Management.Model
{
    public class Resource
    {
        [Key]
        public int resourceId { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }


        public string resourceTitle { get; set; } = "";


        public string resourceDescription { get; set; } = "";


        public string resourceUrl { get; set; } = "";


        public string uploadDate { get; set; } = "";


    }
}
