using System.Collections.Generic;
using System.Linq;

namespace WCFService
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User(1,"First Name", "Last Name", "username", "password" )
            };
        }
        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public User ValidateCredentials(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
        }
    }
}
