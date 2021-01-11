using FamilyTreeDifferentWayApp.Models;
using System;

namespace FamilyTreeDifferentWayApp.Helpers
{
    public static class CreateTree
    {
        public static void ShowFamily(Person person, string dots)
        {
            dots += "---";

            if (person is Parent)
            {
                Console.WriteLine(dots + person.Name);
                var parent = person as Parent;
                foreach (var child in parent.Children)
                {
                    ShowFamily(child, dots);
                }
            }
            else
            {
                Console.WriteLine(dots + person.Name);
            }
        }
    }
}
