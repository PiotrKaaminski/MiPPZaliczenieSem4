using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MiPPZaliczenie.dao;

namespace MiPPZaliczenie.services
{
    class UserService
    {
        private static readonly UserService Instance = new UserService();
        private readonly UserDao _userDao = UserDao.getInstance();
        private UserService() { }

        public static UserService getInstance()
        {
            return Instance;
        }

        public bool RegisterUser(string username, string password)
        {
            if (!ValidateRegisterInput(username, password))
            {
                return false;
            }
            Users user = new Users();
            user.username = username;
            user.password = BCrypt.Net.BCrypt.HashPassword(password);
            _userDao.saveUser(user);
            return true;
        }

        public Users Login(string username, string password)
        {
            if (username == null)
            {
                return null;
            }
            Users user = _userDao.getUserByUsername(username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.password))
            {
                return null;
            }
            return user;
        }

        private bool ValidateRegisterInput(string username, string password)
        {
            if (InvalidLength(username) || InvalidLength(password))
            {
                return false;
            }
            if (HasWhiteSpace(username) || HasWhiteSpace(password))
            {
                return false;
            }
            if (!PasswordContainsRequired(password))
            {
                return false;
            }

            if (!UsernameUnique(username))
            {
                return false;
            }
            return true;
        }

        private bool InvalidLength(string input)
        {
            return input == null || input.Length < 5 || input.Length > 30;
        }

        private bool HasWhiteSpace(string input)
        {
            return input.Any(char.IsWhiteSpace);
        }

        private bool PasswordContainsRequired(string password)
        {
            return password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit);
        }

        private bool UsernameUnique(string username)
        {
            return _userDao.getUserByUsername(username) == null;
        }
    }
}
