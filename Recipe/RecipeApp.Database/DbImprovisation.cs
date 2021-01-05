using RecipeApp.Helpers;
using RecipeApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RecipeApp.Database
{
    public class DbImprovisation: IDbImprovisation
    {
        private ICsvParser _csvParser;
        
        public DbImprovisation (ICsvParser csvParser)
        {
            _csvParser = csvParser;
        }
        public List<Ingredient> GetIngredientList ()
        {
            return _csvParser.ReadCsvFileToIngredient("..\\..\\..\\Files\\Ingredients.csv").ToList();  // path shouldnt be provided here ?
        }

        public List<Recipe> GetRecipeList()
        {
            
            return _csvParser.ReadCsvFileToRecipe("..\\..\\..\\Files\\Recipes.csv").ToList();
        }


        public static List<User> GetUserList()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    FullName = "John Johnson",
                    Recipes = new List<Recipe>()
                },

                new User
                {
                    Id = 2,
                    FullName = "Smith Smooth",
                    Recipes = new List<Recipe>()
                },

                new User
                {
                    Id = 3,
                    FullName = "Jim Jameson",
                    Recipes = new List<Recipe>()
                }
            };
        }
    }
}
