using System.Text.Json.Serialization;

namespace MealRecipeApp.Models;

public class Ingredient
{
    [JsonPropertyName("idIngredient")]
    public string? Id { get; set; }

    [JsonPropertyName("strIngredient")]
    public string? Name { get; set; }

    [JsonPropertyName("strDescription")]
    public string? Description { get; set; }

    [JsonPropertyName("strType")]
    public string? Type { get; set; } = null;
}
