using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Meal
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public MealResponse Recipe { get; set; } =
            new MealResponse { Meals = new List<Recipe>() };

        private readonly ITheMealDBApiService _theMealDBApiService;

        public IndexModel(ITheMealDBApiService theMealDBApiService)
        {
            _theMealDBApiService = theMealDBApiService;
        }

        public async Task OnGetAsync()
        {
            Recipe = await _theMealDBApiService.LookupFullMealDetailsById(id) ??
                new MealResponse { Meals = new List<Recipe>() };
        }
    }
}
