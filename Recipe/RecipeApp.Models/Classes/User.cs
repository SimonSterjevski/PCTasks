using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Models.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string FullName {get; set; }
        public List<Recipe> Recipes { get; set; }

    }
}
