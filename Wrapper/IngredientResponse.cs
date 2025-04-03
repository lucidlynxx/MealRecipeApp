using System.Text.Json.Serialization;
using MealRecipeApp.Models;

namespace MealRecipeApp.Wrapper;

public class IngredientResponse
{
    [JsonPropertyName("meals")]
    public List<Ingredient>? Ingredients { get; set; }
}
