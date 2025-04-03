using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Ingredient
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? ingredient { get; set; }

        public IngredientResponse Ingredients { get; set; } =
            new IngredientResponse { Ingredients = new List<Models.Ingredient>() };

        public CategorizedRecipeResponse categorizedRecipe { get; set; } =
            new CategorizedRecipeResponse { Meals = new List<CategorizedRecipe>() };

        private readonly ITheMealDBApiService _theMealDBApiService;

        public IndexModel(ITheMealDBApiService theMealDBApiService)
        {
            _theMealDBApiService = theMealDBApiService;
        }

        public async Task OnGetAsync()
        {
            if (ingredient != null)
            {
                categorizedRecipe = await _theMealDBApiService.FilterByMainIngredient(ingredient) ??
                    new CategorizedRecipeResponse { Meals = new List<CategorizedRecipe>() };
                ingredient = ingredient;
            }
            else
            {
                Ingredients = await _theMealDBApiService.ListAllIngredients() ??
                    new IngredientResponse { Ingredients = new List<Models.Ingredient>() };
            }
        }
    }
}
