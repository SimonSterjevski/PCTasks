using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public interface IIngredientService
    { 
        List<Ingredient> GetAllIngredients(string path);
        Ingredient GetIngredientById(Guid id, string path);
        List<Ingredient> GetIngredientsByRecipe(Guid recipeId, string path);
    }
}
