using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes(string path);
        Recipe GetRecipeById(Guid id, string path);
        List<Recipe> GetRecipesByUser(int userId, string path);
        List<Recipe> GetRecipesByIngredient(Guid ingredientId, string path);
    }
}
