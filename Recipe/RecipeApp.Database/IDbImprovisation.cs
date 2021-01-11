using RecipeApp.Models.Classes;
using System.Collections.Generic;

namespace RecipeApp.Database
{
    public interface IDbImprovisation
    {
        List<Ingredient> GetIngredientList(string path);
        List<Recipe> GetRecipeList(string path);
        
    }
}