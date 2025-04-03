using System.Text.RegularExpressions;
using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public char? alphabet { get; set; }

    public MealResponse Recipes { get; set; } =
        new MealResponse { Meals = new List<Recipe>() };

    private readonly ITheMealDBApiService _theMealDBApiService;

    public IndexModel(ITheMealDBApiService theMealDBApiService)
    {
        _theMealDBApiService = theMealDBApiService;
    }

    public async Task OnGetAsync()
    {
        if (Regex.IsMatch(alphabet.ToString()!, @"[A-Z]", RegexOptions.IgnoreCase))
        {
            Recipes = await _theMealDBApiService.ListAllMealsByFirstLetter(alphabet) ??
                new MealResponse { Meals = new List<Recipe>() };
        }
    }
}
