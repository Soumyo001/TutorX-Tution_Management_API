using System.ComponentModel.DataAnnotations;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class User
    {
        [Key]
        public int userId {  get; set; }


        public string fullName { get; set; } = "";


        public string phoneNumber { get; set; } = "";

        public string email { get; set; } = "";

        public string password { get; set; } = "";

        public string education { get; set; } = "";

        public string location { get; set; } = "";

        public int userReports { get; set; } = 0;

        public UserCategory type { get; set; }


    }
}
