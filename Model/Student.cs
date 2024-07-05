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


        public string firstName { get; set; } = "";


        public string lastName { get; set; } = "";


        public StudentMedium StudentMedium { get; set; }

        public string studentSelfDescription { get; set; } = "";

    }
}
