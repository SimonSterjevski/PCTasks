using RecipeApp.Database;
using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeApp.Repo
{
    public class IngredientRepo : IRepo<Ingredient>
    {
        private IDbImprovisation _dbImprovisation;
        public IngredientRepo(IDbImprovisation dbImprovisation)
        {
            _dbImprovisation = dbImprovisation;
        }
        public List<Ingredient> GetAll()
        {
            return _dbImprovisation.GetIngredientList();
        }

        public Ingredient GetById(Guid id)
        {
            return _dbImprovisation.GetIngredientList().FirstOrDefault(x => x.Id == id);
        }

    }
}
