using MealRecipeApp.Interfaces;
using MealRecipeApp.Models;
using MealRecipeApp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MealRecipeApp.Pages.Area
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? area { get; set; }

        public AreaResponse Areas { get; set; } =
            new AreaResponse { Areas = new List<Models.Area>() };

        public CategorizedRecipeResponse categorizedRecipe { get; set; } =
            new CategorizedRecipeResponse { Meals = new List<CategorizedRecipe>() };

        private readonly ITheMealDBApiService _theMealDBApiService;

        public IndexModel(ITheMealDBApiService theMealDBApiService)
        {
            _theMealDBApiService = theMealDBApiService;
        }

        public async Task OnGetAsync()
        {
            if (area != null)
            {
                categorizedRecipe = await _theMealDBApiService.FilterByArea(area) ??
                    new CategorizedRecipeResponse { Meals = new List<CategorizedRecipe>() };
                area = area;
            }
            else
            {
                Areas = await _theMealDBApiService.ListAllArea() ??
                    new AreaResponse { Areas = new List<Models.Area>() };
            }
        }
    }
}
