using FamilyTreeApp.Methods;
using FinalyTreeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeApp
{
    class Program
    {

        //public class Item
        //{
        //    public int Id { get; set; }
        //    public int ParentId { get; set; }
        //    public string Name { get; set; }
        //    public string Path { get; set; }
        //    public Item(int id, int parentId, string name)
        //    {
        //        Id = id;
        //        ParentId = parentId;
        //        Name = name;
        //    }
        //}


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

            //FamilyTreeInfo.ShowFamilyTree1(familyMembers, father, new List<Person>());

            //    var items = new List<Item>() {
            //    new Item(1, 0, "Ralph"),
            //    new Item(2, 1, "Ron"),
            //    new Item(3, 2, "Vin"),
            //    new Item(4, 1, "Armando"),
            //    new Item(5, 2, "Alex"),
            //    new Item(6, 3, "Ana")
            //    };
            //    items.ForEach(item => Console.WriteLine($"{item.Name} {GetParentsString(items, item)}"));


            //}

            //static string GetParentsString(List<Item> all, Item current)
            //{
            //    string path = "";
            //    Action<List<Item>, Item> GetPath = null;
            //    GetPath = (List<Item> ps, Item p) => {
            //        var parents = all.Where(x => x.Id == p.ParentId);
            //        foreach (var parent in parents)
            //        {
            //            path += $"{ parent.Name}";
            //            GetPath(ps, parent);
            //        }
            //    };
            //    GetPath(all, current);
            //    string[] split = path.Split(new char[] { '/' });
            //    Array.Reverse(split);
            //    return string.Join("/", split);
            //}
        }
    }
}
