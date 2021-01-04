using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeminarApp.Models
{
    public class Professor : Person
    {
        public string Id { get; set; }
        public SeminarEnrolement SeminarEnrolement { get; set; }
        public override ArrayList GetSeminars()
        {
            List<Seminar> listOfSeminars = SeminarEnrolement.Seminars.Where(x => x.Professor.Id == Id).ToList();
            return new ArrayList(listOfSeminars);
        }

        public override bool IsEligble(string seminarId)
        {
            List<Seminar> listOfSeminars = GetSeminars().Cast<Seminar>().ToList();
            if (!listOfSeminars.Select(x => x.Id).Contains(seminarId))
            {
                return false;
            }
            return true;
        }
    }
}
