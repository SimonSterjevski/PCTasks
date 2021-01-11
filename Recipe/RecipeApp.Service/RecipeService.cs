using RecipeApp.Models.Classes;
using RecipeApp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.Service
{
    public class RecipeService : IRecipeService
    {
        private IUserRepo _userRepo;
        private IRepo<Recipe> _recipeRepo;
        private IRepo<Ingredient> _ingredientRepo;

        public RecipeService(IUserRepo userRepo, IRepo<Recipe> recipeRepo, IRepo<Ingredient> ingredientRepo)
        {
            _userRepo = userRepo;
            _recipeRepo = recipeRepo;
            _ingredientRepo = ingredientRepo;
        }
        public List<Recipe> GetAllRecipes(string path)
        {
            return _recipeRepo.GetAll(path);
        }

        public Recipe GetRecipeById(Guid id, string path)
        {
            return _recipeRepo.GetById(id, path);
        }

        public List<Recipe> GetRecipesByIngredient(Guid ingredientId, string path)
        {
            var ingredient = _ingredientRepo.GetById(ingredientId, path);
            return ingredient.Recipes; // no data yet
        }

        public List<Recipe> GetRecipesByUser(int userId, string path)
        {
            return _recipeRepo.GetAll(path).Where(x => x.UserId == userId).ToList(); // Recipes list in User object is empty
        }
    }
}
