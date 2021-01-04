using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SeminarApp.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public abstract ArrayList GetSeminars();
        public abstract bool IsEligble(string seminarId);
       
    }
}
