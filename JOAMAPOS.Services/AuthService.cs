using System;
using JOAMAPOS.Data;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Services
{
    public class AuthService
    {
        private readonly UserRepository _users = new UserRepository();

        public UserDto Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                throw new BusinessException("Enter username and password.");

            var user = SqlGuard.Query(() => _users.FindByUsername(username.Trim()));

            if (user == null ||
                !user.IsActive ||
                !string.Equals(user.PasswordHash, PasswordHasher.Hash(user.Salt, password),
                               StringComparison.OrdinalIgnoreCase))
                throw new BusinessException("Invalid username or password.");

            SqlGuard.Execute(() => _users.TouchLogin(user.UserId));

            // do not keep secrets in memory after login
            user.PasswordHash = null;
            user.Salt = null;
            Session.CurrentUser = user;
            return user;
        }

        public void Logout()
        {
            Session.Clear();
        }
    }
}