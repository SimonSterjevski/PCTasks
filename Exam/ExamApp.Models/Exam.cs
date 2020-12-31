using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public List<Sit> Sit { get; set; }
        public List<Record> Record { get; set; }
    }
}
