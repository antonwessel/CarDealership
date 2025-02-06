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
        private string username;
        private string password;
        public bool LogIn { get; set; }

        public LoginWebsite(ILogger<LoginWebsite> logger, string username, string password)
        {
            _logger = logger;
            this.username = username;
            this.password = password;
        }
        
        public void OnGet()
        {

        }
        
        public bool Login()
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}