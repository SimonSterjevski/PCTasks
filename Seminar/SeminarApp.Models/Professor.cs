using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeminarApp.Models
{
    public class Professor : Person
    {
        public int Id { get; set; }
        public SeminarEnrolement SeminarEnrolement { get; set; }
        public override ArrayList GetSeminars()
        {
            List<Seminar> listOfSeminars = SeminarEnrolement.Seminars.Where(x => x.Professor.Id == Id).ToList();
            return new ArrayList(listOfSeminars);
        }

        public override bool IsEligble(int seminarId)
        {
            List<Seminar> listOfSeminars = GetSeminars().Cast<Seminar>().ToList();
            return listOfSeminars.Any(x => x.Id == seminarId);
        }
    }
}
