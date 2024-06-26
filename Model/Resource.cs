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

        [Required]
        public string resourceTitle { get; set; } = "";

        [Required]
        public string resourceDescription { get; set; } = "";

        [Required]
        public string resourceUrl { get; set; } = "";

        [Required]
        public string uploadDate { get; set; } = "";

        public User user { get; set; }

    }
}
