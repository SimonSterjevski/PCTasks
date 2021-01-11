using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeDifferentWayApp.Models
{
    public class Parent: Person
    {
        public List<Person> Children { get; set; }
    }
}
