using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    /// <summary>
    /// this model will allow display of detail information about one selected restaurant
    /// model binding
    /// </summary>
    public class DetailModel : PageModel
    {
        public readonly IRestaurantData restaurantData;

        [TempData]                      
        public string Message { get; set; }                 // the message string can be found in TempData
        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetRestaurantById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
