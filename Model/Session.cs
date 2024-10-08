﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tutor_X_Tution_Management.Data.Enum;

namespace Tutor_X_Tution_Management.Model
{
    public class Session
    {
        [Key]
        public int sessionId { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }

        [ForeignKey("Tutor")]
        public int tutorId { get; set; }


        public string startDate { get; set; } = "";


        public string endDate { get; set; } = "";


        public string duration { get; set; } = "";

 
        public SessionStatus sessionStatus { get; set; }
    }
}
