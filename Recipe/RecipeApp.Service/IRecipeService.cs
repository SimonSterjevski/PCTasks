using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(Guid id);
        List<Recipe> GetRecipesByUser(int userId);
        List<Recipe> GetRecipesByIngredient(Guid ingredientId);
    }
}
