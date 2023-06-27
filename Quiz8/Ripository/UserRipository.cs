using Quiz8.Database;
using Quiz8.Models;

namespace Quiz8.Ripository
{
    public class UserRipository : IUserRipository
    {
        public List<User> GetAllUsers()
        {
            return DB.users;
        }
    }
}
