using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarDealership.Pages
{
    public class GlemtAdgangskodeModel : PageModel
    {
        [BindProperty]
        public string EmailInput { get; set; }

        [BindProperty]
        public string PasswordInput { get; set; }
       
    }
}
