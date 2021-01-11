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
        public List<Ingredient> GetAllIngredients(string path)
        {
            return _ingredientRepo.GetAll(path);
        }

        public Ingredient GetIngredientById(Guid id, string path)
        {
            return _ingredientRepo.GetById(id, path);
        }

        public List<Ingredient> GetIngredientsByRecipe(Guid recipeId, string path)
        {
            var recipe = _recipeRepo.GetById(recipeId, path);
            return recipe.Ingredients; // No data yet
        }
    }
}
