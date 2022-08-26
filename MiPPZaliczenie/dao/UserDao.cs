using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPPZaliczenie.dao
{
    class UserDao
    {
        private readonly MiPPMessengerEntities _messengerEntities = new MiPPMessengerEntities();
        private static readonly UserDao Instance = new UserDao();
        private UserDao() { }

        public static UserDao getInstance()
        {
            return Instance;
        }

        public Users getUserByUsername(string username)
        {
            return _messengerEntities.Users.SingleOrDefault(s => s.username.Equals(username));
        }

        public void saveUser(Users user)
        {
            _messengerEntities.Users.Add(user);
            _messengerEntities.SaveChanges();
        }
    }
}
