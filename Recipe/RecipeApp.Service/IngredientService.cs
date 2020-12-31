using RecipeApp.Models.Classes;
using RecipeApp.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public class IngredientService : IIngredientService
    {
        private IRepo<Recipe> _recipeRepo;
        private IRepo<Ingredient> _ingredientRepo;

        public IngredientService(IRepo<Recipe> recipeRepo, IRepo<Ingredient> ingredientRepo)
        {
            _recipeRepo = recipeRepo;
            _ingredientRepo = ingredientRepo;
        }
        public List<Ingredient> GetAllIngredients()
        {
            return _ingredientRepo.GetAll();
        }

        public Ingredient GetIngredientById(Guid id)
        {
            return _ingredientRepo.GetById(id);
        }

        public List<Ingredient> GetIngredientsByRecipe(Guid recipeId)
        {
            var recipe = _recipeRepo.GetById(recipeId);
            return recipe.Ingredients; // No data yet
        }
    }
}
