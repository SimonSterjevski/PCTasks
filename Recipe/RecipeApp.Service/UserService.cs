using RecipeApp.Models.Classes;
using RecipeApp.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Service
{
    public class UserService : IUserService
    {
        private IUserRepo _userRepo;
        private IRepo<Recipe> _recipeRepo;

        public UserService(IUserRepo userRepo, IRepo<Recipe> recipeRepo)
        {
            _userRepo = userRepo;
            _recipeRepo = recipeRepo;
        }
        public List<User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepo.GetById(id);
        }

        public User GetUserByRecipe(Guid id)
        {
            var userId = _recipeRepo.GetById(id).UserId;
            return _userRepo.GetById(userId);  // User object in Recipe will be null, needs to added manually
        }
    }
}
