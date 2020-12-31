using CsvHelper.Configuration;
using RecipeApp.Models.Classes;

namespace RecipeApp.Helpers
{
    public class RecipeMap: ClassMap<Recipe>
    {
        public RecipeMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Name).Name("Name");
            Map(m => m.Instructions).Name("Instructions");
            Map(m => m.Quantity).Name("Quantity");
            Map(m => m.Notes).Name("Notes");
            Map(m => m.SkillLevel).Name("SkillLevel");
            Map(m => m.PreparingTimeInMinutes).Name("PreparingTime");
        }
    }
}