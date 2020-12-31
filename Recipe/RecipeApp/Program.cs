
using Microsoft.Extensions.DependencyInjection;
using RecipeApp.Database;
using RecipeApp.Helpers;
using RecipeApp.Models.Classes;
using RecipeApp.Repo;
using RecipeApp.Service;
using System;
using System.IO;
using System.Linq;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();
            serviceProvider.AddTransient<IUserService, UserService>();
            serviceProvider.AddTransient<IRecipeService, RecipeService>();
            serviceProvider.AddTransient<IIngredientService, IngredientService>();
            serviceProvider.AddTransient<IUserRepo, UserRepo>();
            serviceProvider.AddTransient<IRepo<Recipe>, RecipeRepo>();
            serviceProvider.AddTransient<IRepo<Ingredient>, IngredientRepo>();
            serviceProvider.AddTransient<ICsvParser, CsvParser>();
            serviceProvider.AddTransient<IDbImprovisation, DbImprovisation>();
            IServiceProvider _sP = serviceProvider.BuildServiceProvider();

            var user = _sP.GetService<IUserService>();
            var recipe = _sP.GetService<IRecipeService>();
            var ingredient = _sP.GetService<IIngredientService>();

            var allUsers = user.GetAllUsers();
            var ingredientById = ingredient.GetIngredientById(new Guid("5800170F-C1C7-C8F5-78B5-C95A20C6129D"));
            var recipesByUser = recipe.GetRecipesByUser(2);

           
            Console.WriteLine(allUsers[0].FullName);
            Console.WriteLine("--------------");
            Console.WriteLine(ingredientById.Name);
            Console.WriteLine("--------------");
            Console.WriteLine(recipesByUser.Count);

            Console.ReadLine();
        }
    }
}
