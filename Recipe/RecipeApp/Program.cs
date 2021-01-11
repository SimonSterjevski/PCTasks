
using Microsoft.Extensions.DependencyInjection;
using RecipeApp.Database;
using RecipeApp.Helpers;
using RecipeApp.Models.Classes;
using RecipeApp.Repo;
using RecipeApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependencies
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

            var pathIngredient = "..\\..\\..\\Ingredients.csv";
            var pathRecipe = "..\\..\\..\\Recipes.csv";
           
            var allUsers = user.GetAllUsers();
            var ingredientById = ingredient.GetIngredientById(new Guid("5800170F-C1C7-C8F5-78B5-C95A20C6129D"), pathIngredient);
            var recipesByUser = recipe.GetRecipesByUser(2, pathRecipe);


            // Adding data
            var recipeOne = new Recipe { 
                Id = Guid.NewGuid(),
                Name = "Homemade bread", 
                Instructions = "Please ask google how to prepare. It knows better", 
                Ingredients = new List<Ingredient>()};
            var recipeTwo = new Recipe
            {
                Id = Guid.NewGuid(),
                Name = "Pancakes",
                Instructions = "Please ask google how to prepare. It knows better",
                Ingredients = new List<Ingredient>()
            };
            var ingredientOne = new Ingredient 
            {
                Id = Guid.NewGuid(),
                Name = "Water",
            };
            var ingredientTwo = new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Yeast",
            };
            var ingredientThree = new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Hops",
            }; ;
            var ingredientFour = new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Egg",
            };
            var ingredientFive = new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Milk",
            };
            var userOne = new User { Id = 4, FullName = "Stevo Karapandza", Recipes = new List<Recipe>()};
            recipeOne.Ingredients.Add(ingredientOne);
            recipeOne.Ingredients.Add(ingredientTwo);
            recipeOne.Ingredients.Add(ingredientThree);
            recipeTwo.Ingredients.Add(ingredientOne);
            recipeTwo.Ingredients.Add(ingredientFour);
            recipeTwo.Ingredients.Add(ingredientFive);
            userOne.Recipes.Add(recipeOne);
            userOne.Recipes.Add(recipeTwo);
            var newUsers = new List<User> { userOne };

            newUsers.ForEach(x => {
                Console.WriteLine();
                Console.WriteLine($"{x.FullName} has {x.Recipes.Count} recipes:");
                x.Recipes.ForEach(x =>
                {
                    Console.WriteLine($"Recipe {x.Name} has {x.Ingredients.Count} ingredients:");
                    x.Ingredients.ForEach(x =>
                    {
                        Console.WriteLine($"{x.Name}");
                    });
                    Console.WriteLine($"{x.Instructions}");
                });
            });

            //Console.WriteLine("--------------");
            //Console.WriteLine(allUsers[0].FullName);
            //Console.WriteLine("--------------");
            //Console.WriteLine(ingredientById.Name);
            //Console.WriteLine("--------------");
            //Console.WriteLine($"Num of recipes: {recipesByUser.Count}");

            Console.ReadLine();
        }
    }
}
