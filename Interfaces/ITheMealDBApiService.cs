using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;

namespace MealRecipeApp.Interfaces;

public interface ITheMealDBApiService
{
    Task<MealResponse> SearchMealByName(string? name);
    Task<MealResponse> ListAllMealsByFirstLetter(char? letter);
    Task<MealResponse> LookupFullMealDetailsById(int? id);
    Task<MealResponse> LookupASingleRandomMeal();
    Task<CategoryResponse> ListAllMealCategories();
    Task<List<Category>> ListAllCategories();
    Task<AreaResponse> ListAllArea();
    Task<IngredientResponse> ListAllIngredients();
    Task<CategorizedRecipeResponse> FilterByMainIngredient(string? ingredient);
    Task<CategorizedRecipeResponse> FilterByCategory(string? category);
    Task<CategorizedRecipeResponse> FilterByArea(string? area);
}
