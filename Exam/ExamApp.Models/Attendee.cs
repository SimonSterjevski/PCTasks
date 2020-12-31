using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Models
{

    // Same as Student entity ??
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Sit> Sit { get; set; }
    }
}
