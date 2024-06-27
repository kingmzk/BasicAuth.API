
namespace BasicAuth.API
{
    public static class ValidateUser
    {
        public static (bool isValid, string[] roles) Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return (true, new[] { "Admin" });
            }
            else if (username == "user" && password == "password")
            {
                return (true, new[] { "User" });
            }
            else
            {
                return (false, null);
            }
        }
    }
}












/*namespace BasicAuth.API
{
    public class ValidateUser
    {
        public static bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}*/