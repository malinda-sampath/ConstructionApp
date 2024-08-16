using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionApp.Models;

namespace ConstructionApp.Repositories
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
