using ClassLibrary.Core.Models;
using ClassLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarDealership.Pages;

public class LoginWebsite : PageModel
{
    private readonly UserService _userService;

    public List<User> Users { get; set; }

    public LoginWebsite(UserService userService)
    {
        _userService = userService;
    }

    public void OnGet()
    {
        Users = _userService.GetUsers();
    }
}