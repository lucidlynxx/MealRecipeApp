using System.Text.Json.Serialization;
using MealRecipeApp.Models;

namespace MealRecipeApp.Wrapper;

public class CategorizedRecipeResponse
{
    [JsonPropertyName("meals")]
    public List<CategorizedRecipe>? Meals { get; set; }
}
