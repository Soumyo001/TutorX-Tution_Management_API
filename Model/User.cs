using System.ComponentModel.DataAnnotations;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class User
    {
        [Key]
        public int userId {  get; set; }

        [Required]
        public string fullName { get; set; } = "";

        [Required]
        public string phoneNumber { get; set; } = "";

        [Required]
        public string email { get; set; } = "";

        [Required]
        public string password { get; set; } = "";

        [Required]
        public string education { get; set; } = "";

        [Required]
        public string location { get; set; } = "";

        [Required]
        public UserCategory type { get; set; }

        public ICollection<Tutor> tutors { get; set; }

        public ICollection<Student> students { get; set; }

        public ICollection<Resource> resources { get; set; }

    }
}
