using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int RecorcardId { get; set; }
        public Recordcard Recordcard { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
