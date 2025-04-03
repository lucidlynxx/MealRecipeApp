using System.Text.Json.Serialization;

namespace MealRecipeApp.Models;

public class CategorizedRecipe
{
    [JsonPropertyName("strMeal")]
    public string? Name { get; set; }

    [JsonPropertyName("strMealThumb")]
    public string? Thumb { get; set; }

    [JsonPropertyName("idMeal")]
    public string? Id { get; set; }
}
