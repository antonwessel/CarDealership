using ClassLibrary.Core.Helpers;
using ClassLibrary.Core.Models;
using ClassLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarDealership.Pages
{
    public class NulstillingKodeModel : PageModel

    {
        private readonly UserService _userService;
        private readonly User _user;
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Id { get; set; }

        [BindProperty]
        public string NewKode { get; set; }

        public NulstillingKodeModel(UserService userService)
        {
            _userService = userService;   
        }

        public IActionResult OnGet(string email, string id)
        {
            Email = email;
            Id = id;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewKode))
            {
                ModelState.AddModelError("", "Adgangskode er påkrævet.");
                return Page();
            }

            // Valider id (i en rigtig app, brug en database til at gemme Ids)
            bool isEmailValid = _userService.VerifyEmail(Email);
            if (!isEmailValid)
            {
                ModelState.AddModelError("", "Ugyldigt eller udløbet id.");
                return Page();
            }


            // Opdater adgangskoden
            _userService.UpdateUsername(Email, NewKode);

            return RedirectToPage("LoginWebsite");
        }
    }
}

