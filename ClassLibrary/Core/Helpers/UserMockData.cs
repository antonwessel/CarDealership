using ClassLibrary.Core.Models;

namespace ClassLibrary.Core.Helpers;

public class UserMockData
{
    private static readonly List<User> _users = [new User("bob@gmail.com", "123"), new User("john@gmail.com", "4321")];

    public static List<User> GetUsers() => _users;
}
