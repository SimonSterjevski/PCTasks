using FamilyTreeApp.Methods;
using FinalyTreeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var breadley = new Person(1, "Bradley", new DateTime(1930, 1, 18), 0);
            var damian = new Person(2, "Damian", new DateTime(1960, 1, 24), 1);
            var chriss = new Person(3, "Khris", new DateTime(1969, 5, 19), 1);
            var pascal = new Person(4, "Pascal", new DateTime(1986, 7, 21), 2);
            var jason = new Person(5, "Josh", new DateTime(1964, 10, 18), 1);
            var ivica = new Person(6, "Ivica", new DateTime(2014, 2, 24), 4);
            var terry = new Person(7, "Terry", new DateTime(1989, 4, 3), 2);
            var tomas = new Person(8, "Thomas", new DateTime(2001, 12, 7), 3);

            List<Person> familyMembers = new List<Person> { breadley, damian, chriss, pascal, jason, ivica, terry, tomas };
            List<int> usedlistIds = new List<int>();
            string dots = "-";

            List<int> listIds = FamilyTreeInfo.FindIds(familyMembers);
            Person oldest = FamilyTreeInfo.FindAndShowOldest(familyMembers, dots, usedlistIds);
            FamilyTreeInfo.ShowFamilyTree(oldest.Id, dots, familyMembers, usedlistIds, listIds);

            Console.ReadLine();


           

        }
    }
}
