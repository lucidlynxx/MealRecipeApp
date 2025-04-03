using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Random
{
    public class IndexModel : PageModel
    {
        public MealResponse Recipe { get; set; } =
            new MealResponse { Meals = new List<Recipe>() };

        private readonly ITheMealDBApiService _theMealDBApiService;

        public IndexModel(ITheMealDBApiService theMealDBApiService)
        {
            _theMealDBApiService = theMealDBApiService;
        }

        public async Task OnGetAsync()
        {
            Recipe = await _theMealDBApiService.LookupASingleRandomMeal() ??
                new MealResponse { Meals = new List<Recipe>() };
        }
    }
}
