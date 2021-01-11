using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeminarApp.Models
{
    public class Student: Person
    {
        new public string Name => base.Name;  // ?
        new public DateTime Birthday => base.Birthday;  // ?
        public Student(string name, DateTime birthday)  // ?
        {
            base.Name = name;
            base.Birthday = birthday;
        }
        public int Id { get; set; }
        public SeminarEnrolement SeminarEnrolement { get; set; }
        public override ArrayList GetSeminars() 
        {
            List<Seminar> listOfSeminars = SeminarEnrolement.Seminars.Where(x => x.WaitingList.Select(x => x.Id).Contains(Id)).ToList();
            return new ArrayList(listOfSeminars);
        }
        public override bool IsEligble(int seminarId)
        {
            List<Seminar> listOfSeminars = GetSeminars().Cast<Seminar>().ToList();
            return listOfSeminars.Any(x => x.Id == seminarId);
        }

    }
}
