using System;

namespace FinalyTreeApp.Models
{
    public class Person
    {
        public Person(int id, string name, DateTime birthday, int parentId)
        {
            Id = id;
            Name = name;
            DateOfBirth = birthday;
            ParentId = parentId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
    }
}
