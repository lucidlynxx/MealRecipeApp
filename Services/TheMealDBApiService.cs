using System.Text.Json;
using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;

namespace MealRecipeApp.Services;

public class TheMealDBApiService : ITheMealDBApiService
{
    private readonly HttpClient _client;

    public TheMealDBApiService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://www.themealdb.com/api/json/v1/1/");
    }

    public async Task<CategorizedRecipeResponse> FilterByArea(string? area)
    {
        var response = await _client.GetAsync($"filter.php?a={area}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        CategorizedRecipeResponse? result = JsonSerializer.Deserialize<CategorizedRecipeResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<CategorizedRecipeResponse> FilterByCategory(string? category)
    {
        var response = await _client.GetAsync($"filter.php?c={category}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        CategorizedRecipeResponse? result = JsonSerializer.Deserialize<CategorizedRecipeResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<CategorizedRecipeResponse> FilterByMainIngredient(string? ingredient)
    {
        var response = await _client.GetAsync($"filter.php?i={ingredient}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        CategorizedRecipeResponse? result = JsonSerializer.Deserialize<CategorizedRecipeResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<AreaResponse> ListAllArea()
    {
        var response = await _client.GetAsync("list.php?a=list");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        AreaResponse? result = JsonSerializer.Deserialize<AreaResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public Task<List<Category>> ListAllCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<IngredientResponse> ListAllIngredients()
    {
        var response = await _client.GetAsync("list.php?i=list");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        IngredientResponse? result = JsonSerializer.Deserialize<IngredientResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<CategoryResponse> ListAllMealCategories()
    {
        var response = await _client.GetAsync($"categories.php");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        CategoryResponse? result = JsonSerializer.Deserialize<CategoryResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<MealResponse> ListAllMealsByFirstLetter(char? letter)
    {
        var response = await _client.GetAsync($"search.php?f={letter}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        MealResponse? result = JsonSerializer.Deserialize<MealResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<MealResponse> LookupASingleRandomMeal()
    {
        var response = await _client.GetAsync($"random.php");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        MealResponse? result = JsonSerializer.Deserialize<MealResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<MealResponse> LookupFullMealDetailsById(int? id)
    {
        var response = await _client.GetAsync($"lookup.php?i={id}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        MealResponse? result = JsonSerializer.Deserialize<MealResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }

    public async Task<MealResponse> SearchMealByName(string? name)
    {
        var response = await _client.GetAsync($"search.php?s={name}");

        response.EnsureSuccessStatusCode();

        var stringResponse = await response.Content.ReadAsStringAsync();

        MealResponse? result = JsonSerializer.Deserialize<MealResponse>(stringResponse, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result!;
    }
}
