using ClassLibrary.Core.Helpers;
using ClassLibrary.Core.Models;
using ClassLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarDealership.Pages;

public class LoginWebsite : PageModel
{
    private readonly UserService _userService;

    [BindProperty]
    public string EmailInput { get; set; }

    [BindProperty]
    public string PasswordInput { get; set; }

    public List<User> Users { get; set; }

    [BindProperty]
    public User UserLoggedIn { get; set; }

    public LoginWebsite(UserService userService)
    {
        _userService = userService;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        Users = _userService.GetUsers();
        UserLoggedIn = Users.FirstOrDefault(user => user.Email == EmailInput && user.Password == PasswordInput);

        if (UserLoggedIn == null)
        {
            return Page();
        }
        else
        {
            UserState.CurrentUser = UserLoggedIn;
            return RedirectToPage("Index");
        }
    }


}