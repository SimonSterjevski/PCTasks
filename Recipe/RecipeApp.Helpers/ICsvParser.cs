using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Helpers
{
    public interface ICsvParser
    {
        List<Recipe> ReadCsvFileToRecipe(string path);
        List<Ingredient> ReadCsvFileToIngredient(string path);
    }
}
