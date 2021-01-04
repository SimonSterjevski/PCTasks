using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeminarApp.Models
{
    public class Seminar
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public Professor Professor { get; set; }
        public List<Student> WaitingList { get; set; }

        public void AddStudent(Student student)
        {
            if (WaitingList.Select(x => x.Id).Contains(student.Id))
            {
                Console.WriteLine("Student exists!");
            } else
            {
                WaitingList.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            if (!WaitingList.Select(x => x.Id).Contains(student.Id))
            {
                Console.WriteLine("No such student");
            } else
            {
                WaitingList.Remove(student);
            }
           
        }
    }
}
