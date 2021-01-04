using FinalyTreeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeApp.Methods
{
    public static class FamilyTreeInfo
    {
        public static Person FindAndShowOldest(List<Person> family, string dots, List<int> usedIds)
        {
            Person oldest = family.FirstOrDefault(x => x.ParentId == 0);
            usedIds.Add(oldest.Id);
            Console.WriteLine(dots + oldest.Name);
            return oldest;
        }

        public static List<int> FindIds(List<Person> family)
        {
            List<int> ids = family.Where(x => x.ParentId != 0).Select(x => x.ParentId).ToList();
            return ids;
        }


        public static void ShowFamilyTree(int id, string newDots, List<Person> family, List<int> usedIds, List<int> listIds)
        {
            newDots += "---";
            Person father = family.FirstOrDefault(x => x.Id == id);
            foreach (var person in family)
            {
                if (person.ParentId != 0 && person.ParentId == id && !usedIds.Contains(person.Id))
                {
                    Console.WriteLine($"{newDots} {person.Name}, son of {father.Name}");
                    usedIds.Add(person.Id);
                    if (listIds.Contains(person.Id))
                    {
                        ShowFamilyTree(person.Id, newDots, family, usedIds, listIds);
                    }
                }
            }
            //newDots = dots.Remove(dots.Length - 3);
        }
    }
}
