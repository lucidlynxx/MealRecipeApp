using System.Text.Json.Serialization;
using MealRecipeApp.Models;

namespace MealRecipeApp.Wrapper;

public class AreaResponse
{
    [JsonPropertyName("meals")]
    public List<Area>? Areas { get; set; }
}
