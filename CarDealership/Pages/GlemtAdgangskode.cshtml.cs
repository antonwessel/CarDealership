using ClassLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarDealership.Pages
{
    public class GlemtAdgangskodeModel : PageModel
    {
        private readonly UserService _userService;

        [BindProperty]
        public string EmailInput { get; set; }
        public GlemtAdgangskodeModel()
        {
            _userService = new UserService(); 
        }

        public IActionResult OnPost()
        {
            // 📞 Vi bruger telefonen (UserService) til at spørge, om e-mailen findes
            bool emailExists = _userService.VerifyEmail(EmailInput);

            if (emailExists)
            {
                // Hvis e-mailen findes, går vi videre til næste side
                return RedirectToPage("NulstillingKode");
            }
            else
            {
                // Hvis e-mailen ikke findes, viser vi en fejlbesked
                ModelState.AddModelError("", "E-mailen findes ikke.");
                return Page(); // Vi bliver på samme side
            }
        }

    
       

    }
}
