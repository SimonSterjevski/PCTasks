using CsvHelper.Configuration;
using RecipeApp.Models.Classes;

namespace RecipeApp.Helpers
{
    public class IngredientMap: ClassMap<Ingredient>
    {
        public IngredientMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Name).Name("Name");
            Map(m => m.Quantity).Name("Quantity");
            Map(m => m.Unit).Name("Unit");
        }
    }
}