using System.Text.Json.Serialization;

namespace MealRecipeApp.Models;

public class Recipe
{
    [JsonPropertyName("idMeal")]
    public string? Id { get; set; }

    [JsonPropertyName("strMeal")]
    public string? Name { get; set; }

    [JsonPropertyName("strMealAlternate")]
    public string? MealAlternate { get; set; } = null;

    [JsonPropertyName("strCategory")]
    public string? Category { get; set; }

    [JsonPropertyName("strArea")]
    public string? Area { get; set; }

    [JsonPropertyName("strInstructions")]
    public string? Instructions { get; set; }

    [JsonPropertyName("strMealThumb")]
    public string? Thumb { get; set; }

    [JsonPropertyName("strTags")]
    public string? Tags { get; set; }

    [JsonPropertyName("strYoutube")]
    public string? Youtube { get; set; }

    [JsonPropertyName("strIngredient1")]
    public string? Ingredient1 { get; set; } = null;

    [JsonPropertyName("strIngredient2")]
    public string? Ingredient2 { get; set; } = null;

    [JsonPropertyName("strIngredient3")]
    public string? Ingredient3 { get; set; } = null;

    [JsonPropertyName("strIngredient4")]
    public string? Ingredient4 { get; set; } = null;

    [JsonPropertyName("strIngredient5")]
    public string? Ingredient5 { get; set; } = null;

    [JsonPropertyName("strIngredient6")]
    public string? Ingredient6 { get; set; } = null;

    [JsonPropertyName("strIngredient7")]
    public string? Ingredient7 { get; set; } = null;

    [JsonPropertyName("strIngredient8")]
    public string? Ingredient8 { get; set; } = null;

    [JsonPropertyName("strIngredient9")]
    public string? Ingredient9 { get; set; } = null;

    [JsonPropertyName("strIngredient10")]
    public string? Ingredient10 { get; set; } = null;

    [JsonPropertyName("strIngredient11")]
    public string? Ingredient11 { get; set; } = null;

    [JsonPropertyName("strIngredient12")]
    public string? Ingredient12 { get; set; } = null;

    [JsonPropertyName("strIngredient13")]
    public string? Ingredient13 { get; set; } = null;

    [JsonPropertyName("strIngredient14")]
    public string? Ingredient14 { get; set; } = null;

    [JsonPropertyName("strIngredient15")]
    public string? Ingredient15 { get; set; } = null;

    [JsonPropertyName("strIngredient16")]
    public string? Ingredient16 { get; set; } = null;

    [JsonPropertyName("strIngredient17")]
    public string? Ingredient17 { get; set; } = null;

    [JsonPropertyName("strIngredient18")]
    public string? Ingredient18 { get; set; } = null;

    [JsonPropertyName("strIngredient19")]
    public string? Ingredient19 { get; set; } = null;

    [JsonPropertyName("strIngredient20")]
    public string? Ingredient20 { get; set; } = null;

    [JsonPropertyName("strMeasure1")]
    public string? Measure1 { get; set; } = null;

    [JsonPropertyName("strMeasure2")]
    public string? Measure2 { get; set; } = null;

    [JsonPropertyName("strMeasure3")]
    public string? Measure3 { get; set; } = null;

    [JsonPropertyName("strMeasure4")]
    public string? Measure4 { get; set; } = null;

    [JsonPropertyName("strMeasure5")]
    public string? Measure5 { get; set; } = null;

    [JsonPropertyName("strMeasure6")]
    public string? Measure6 { get; set; } = null;

    [JsonPropertyName("strMeasure7")]
    public string? Measure7 { get; set; } = null;

    [JsonPropertyName("strMeasure8")]
    public string? Measure8 { get; set; } = null;

    [JsonPropertyName("strMeasure9")]
    public string? Measure9 { get; set; } = null;

    [JsonPropertyName("strMeasure10")]
    public string? Measure10 { get; set; } = null;

    [JsonPropertyName("strMeasure11")]
    public string? Measure11 { get; set; } = null;

    [JsonPropertyName("strMeasure12")]
    public string? Measure12 { get; set; } = null;

    [JsonPropertyName("strMeasure13")]
    public string? Measure13 { get; set; } = null;

    [JsonPropertyName("strMeasure14")]
    public string? Measure14 { get; set; } = null;

    [JsonPropertyName("strMeasure15")]
    public string? Measure15 { get; set; } = null;

    [JsonPropertyName("strMeasure16")]
    public string? Measure16 { get; set; } = null;

    [JsonPropertyName("strMeasure17")]
    public string? Measure17 { get; set; } = null;

    [JsonPropertyName("strMeasure18")]
    public string? Measure18 { get; set; } = null;

    [JsonPropertyName("strMeasure19")]
    public string? Measure19 { get; set; } = null;

    [JsonPropertyName("strMeasure20")]
    public string? Measure20 { get; set; } = null;

    [JsonPropertyName("strSource")]
    public string? Source { get; set; } = null;

    [JsonPropertyName("strImageSource")]
    public string? ImageSource { get; set; } = null;

    [JsonPropertyName("strCreativeCommonsConfirmed")]
    public string? CreativeCommonsConfirmed { get; set; } = null;

    [JsonPropertyName("dateModified")]
    public string? DateModified { get; set; } = null;
}
