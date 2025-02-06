namespace CarDealership.Core
{
    public static class AdminState
    {

        private static readonly string _username = "User";   
        private static readonly string _password = "12345";   
        public static bool IsUserLoggedIn { get; private set; }

        public static bool IsAdminLogin(string username, string password)

        {
            if (username == _username && password==_password )
            {
                IsUserLoggedIn=true;
                return true;    
            }
            return false;   

        }

        public static void Logout()
        {
            IsUserLoggedIn = false; 
        }

    }
}
