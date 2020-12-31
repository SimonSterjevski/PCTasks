using RecipeApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Models.Classes
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public ServingQuantity Quantity { get; set; }
        public string Notes { get; set; }
        public string SkillLevel { get; set; }
        public int PreparingTimeInMinutes { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }   
}
