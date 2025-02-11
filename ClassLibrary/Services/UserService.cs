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
    
    public  bool UpdateUsername (string email, string newkode)
    {
        var users = UserMockData.GetUsers();    
        var user = users.FirstOrDefault(u => u.Email == email);

        if (user != null)
        {
           user.Password = newkode;
            return true;
        }
        return false;
    }

    public bool VerifyEmail (string email)

    {
        var users = UserMockData.GetUsers();
        var user = users.FirstOrDefault(u => u.Email == email);

        if (user != null)
        {
            user.Email = email;
            return true;
        }
        return false;
    }

}
