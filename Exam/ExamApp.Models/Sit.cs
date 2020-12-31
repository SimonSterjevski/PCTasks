using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Models
{
    public class Sit
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
        
    }
}
