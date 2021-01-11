using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public double Fees { get; set; }
        public List<Seminar> Seminars {get; set; }
        protected string Description { get; set; }
        public void GetDescription()
        {
            Console.WriteLine("Hardest course ever!!!");
            Console.WriteLine("Look at the seminars bellow:");
            Seminars.ForEach(x => Console.WriteLine(x.Title));
        }
    }
}
