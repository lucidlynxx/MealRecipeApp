using MealRecipeApp.Interfaces;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Category
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? category { get; set; }

        public CategoryResponse Categories { get; set; } =
            new CategoryResponse { Categories = new List<Models.Category>() };

        public CategorizedRecipeResponse categorizedRecipe { get; set; } =
            new CategorizedRecipeResponse { Meals = new List<Models.CategorizedRecipe>() };

        private readonly ITheMealDBApiService _theMealDBApiService;

        public IndexModel(ITheMealDBApiService theMealDBApiService)
        {
            _theMealDBApiService = theMealDBApiService;
        }

        public async Task OnGetAsync()
        {
            if (category != null)
            {
                categorizedRecipe = await _theMealDBApiService.FilterByCategory(category) ??
                    new CategorizedRecipeResponse { Meals = new List<Models.CategorizedRecipe>() };
                category = category;
            }
            else
            {
                Categories = await _theMealDBApiService.ListAllMealCategories() ??
                    new CategoryResponse { Categories = new List<Models.Category>() };
            }
        }
    }
}
