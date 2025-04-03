using System.Text.Json.Serialization;

namespace MealRecipeApp.Models;

public class Area
{
    [JsonPropertyName("strArea")]
    public string? Name { get; set; }
}
