using FamilyTreeDifferentWayApp.Helpers;
using FamilyTreeDifferentWayApp.Models;
using System;
using System.Collections.Generic;

namespace FamilyTreeDifferentWayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ancestor myAncestor = new Ancestor
            {
                Name = "Jovan",
                Children = new List<Person>
            {
                new Parent()
                {
                    Name = "Boris",
                    Children = new List<Person>
                    {
                        new Child { Name = "Bruno"}
                    }
                },
                new Child { Name = "Marija" },
                new Parent
                {
                    Name = "Bosko",
                    Children = new List<Person>
                    {
                        new Child { Name = "Zoran" },
                        new Child { Name = "Bisera" }
                    }
                }
            }
            };
            CreateTree.ShowFamily(myAncestor, "");

            Console.ReadLine();
        }
    }
}
