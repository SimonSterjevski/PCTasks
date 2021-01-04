using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarApp.Models
{
    public class SeminarEnrolement
    {
        public int Id { get; set; }
        public List<Seminar> Seminars { get; set; }
        public double MarksRecieved { get; set; }  /// why the type is double ?

        public double GetAvgToDate()    
        {
            return 0;
        }

        public double GetFinalMark()
        {
            return 0;
        }
    }
}
