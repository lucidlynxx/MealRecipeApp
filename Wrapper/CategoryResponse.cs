using System.Text.Json.Serialization;
using MealRecipeApp.Models;

namespace MealRecipeApp.Wrapper;

public class CategoryResponse
{
    [JsonPropertyName("categories")]
    public List<Category>? Categories { get; set; }
}
