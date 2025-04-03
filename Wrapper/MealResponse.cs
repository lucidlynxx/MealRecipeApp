using System.Text.Json.Serialization;
using MealRecipeApp.Models;

namespace MealRecipeApp.Wrapper;

public class MealResponse
{
    [JsonPropertyName("meals")]
    public List<Recipe>? Meals { get; set; }
}
