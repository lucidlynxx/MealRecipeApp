using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Search;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string? name { get; set; }

    public MealResponse Recipes { get; set; } =
        new MealResponse { Meals = new List<Recipe>() };

    private readonly ITheMealDBApiService _theMealDBApiService;

    public IndexModel(ITheMealDBApiService theMealDBApiService)
    {
        _theMealDBApiService = theMealDBApiService;
    }

    public async Task OnGetAsync()
    {
        if (!string.IsNullOrEmpty(name))
        {
            Recipes = await _theMealDBApiService.SearchMealByName(name) ??
                new MealResponse { Meals = new List<Recipe>() };
        }
    }
}