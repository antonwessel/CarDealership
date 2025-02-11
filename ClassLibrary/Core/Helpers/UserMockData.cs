using ClassLibrary.Core.Models;

namespace ClassLibrary.Core.Helpers;

public class UserMockData
{
    private static readonly List<User> _users = [new User("bob@gmail.com", "123", "Bob"), new User("john@gmail.com", "4321", "John")];

    public static List<User> GetUsers() => _users;


}
