using RecipeApp.Database;
using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.Repo
{
    public class RecipeRepo : IRepo<Recipe>
    {
        private IDbImprovisation _dbImprovisation;
        public RecipeRepo(IDbImprovisation dbImprovisation)
        {
            _dbImprovisation = dbImprovisation;
        }
        public List<Recipe> GetAll()
        {
            return _dbImprovisation.GetRecipeList();
        }

        public Recipe GetById(Guid id)
        {
            return _dbImprovisation.GetRecipeList().FirstOrDefault(x => x.Id == id);
        }

    }
}
