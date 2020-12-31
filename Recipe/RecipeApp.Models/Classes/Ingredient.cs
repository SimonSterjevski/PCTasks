using RecipeApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Models.Classes
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public UnitMeasure Unit { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
