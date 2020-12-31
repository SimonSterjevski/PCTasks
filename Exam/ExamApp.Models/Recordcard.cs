using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Models
{
    public class Recordcard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }
        public Subject Subject { get; set; }
        public List<Record> Record { get; set; }
    }
}
