using ClassLibrary.Core.Helpers;
using ClassLibrary.Core.Models;

namespace ClassLibrary.Services;

public class UserService
{
    public List<User> AllUsers { get; set; }

    public UserService()
    {
        AllUsers = UserMockData.GetUsers();
    }

    public List<User> GetUsers() => AllUsers;
    
}
