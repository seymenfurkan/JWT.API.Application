namespace JWT.API.Application.Models
{
    public class UserConstants
    {
        public static List<User> Users = new List<User>()
        {
            new () {UserName = "mufuse" , Password ="123456",Role="Admin"},
            new () {UserName = "scekin" , Password ="654321",Role="User"},
        };
    }
}
