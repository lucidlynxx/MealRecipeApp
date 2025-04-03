using System.Text.Json.Serialization;

namespace MealRecipeApp.Models;

public class Category
{
    [JsonPropertyName("idCategory")]
    public string? Id { get; set; }

    [JsonPropertyName("strCategory")]
    public string? Name { get; set; }

    [JsonPropertyName("strCategoryThumb")]
    public string? Thumb { get; set; }

    [JsonPropertyName("strCategoryDescription")]
    public string? Description { get; set; }
}
