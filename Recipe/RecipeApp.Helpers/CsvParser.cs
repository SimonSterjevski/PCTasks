using CsvHelper;
using RecipeApp.Models.Classes;
using RecipeApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RecipeApp.Helpers
{
    public class CsvParser: ICsvParser
    {

        public List<Ingredient> ReadCsvFileToIngredient(string path)
        {
            using (var reader = new StreamReader(path, Encoding.Default))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                csv.Configuration.RegisterClassMap<IngredientMap>();
                var records = csv.GetRecords<Ingredient>().ToList();
                return records;
            }
        }

        public List<Recipe> ReadCsvFileToRecipe(string path)
        {
            Random random = new Random();
            using (var reader = new StreamReader(path, Encoding.Default))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                csv.Configuration.RegisterClassMap<RecipeMap>();
                var records = csv.GetRecords<Recipe>().ToList();
                foreach (var recipe in records)
                {
                    recipe.UserId = random.Next(1, 4);
                }
                return records;
            }
        }
    }
}
