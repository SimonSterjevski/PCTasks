using SeminarApp.Models;
using System;

namespace SeminarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Boba", new DateTime(2003, 12, 12));

            Console.WriteLine(student1.Name);

            Console.ReadLine();
        }
    }
}
