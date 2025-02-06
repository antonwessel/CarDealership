using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CarDealership.Pages
{
    public class LoginWebsite : PageModel
    {
        private readonly ILogger<LoginWebsite> _logger;
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public LoginWebsite(ILogger<LoginWebsite> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public void LogIn()
        {
            if (string.IsNullOrEmpty(Email)) throw new ArgumentNullException("Email is required");
            if (string.IsNullOrEmpty(Password)) throw new ArgumentNullException("Password is required");
            else
            {
                IsLoggedIn = true;
            }
        }

        public IActionResult OnPost()
        {
            LogIn();
            return RedirectToPage("LoginWebsite");
        }
    }
}