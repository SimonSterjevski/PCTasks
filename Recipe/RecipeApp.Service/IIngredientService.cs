using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public interface IIngredientService
    { 
        List<Ingredient> GetAllIngredients();
        Ingredient GetIngredientById(Guid id);
        List<Ingredient> GetIngredientsByRecipe(Guid recipeId);
    }
}
