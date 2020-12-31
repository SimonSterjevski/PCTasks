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
            string relPath = Path.GetRelativePath("Ingredients.csv", @"C:\Users\User\Desktop\Tasks\Recipe\RecipeApp.Database\Ingredients.csv");
            Console.WriteLine(relPath);
            return _csvParser.ReadCsvFileToIngredient(@"C:\Users\User\Desktop\Tasks\Recipe\RecipeApp.Database\Ingredients.csv").ToList();
            //return _csvParser.ReadCsvFileToIngredient(@"..\..\..\..\..\RecipeApp.Database\Ingredients.csv").ToList(); 
        }

        public List<Recipe> GetRecipeList()
        {
            string relPath = Path.GetRelativePath("Recipes.csv", @"C:\Users\User\Desktop\Tasks\Recipe\RecipeApp.Database\Recipes.csv");
            Console.WriteLine(relPath);
            return _csvParser.ReadCsvFileToRecipe(@"C:\Users\User\Desktop\Tasks\Recipe\RecipeApp.Database\Recipes.csv").ToList();
            //return _csvParser.ReadCsvFileToRecipe(@"..\..\..\..\..\RecipeApp.Database\Recipes.csv").ToList();
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
