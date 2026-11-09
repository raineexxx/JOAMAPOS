using System;
using System.Linq;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Data
{
    public class UserRepository
    {
        // dbo.usp_Login
        public UserDto FindByUsername(string username)
        {
            using (var db = DbFactory.Create())
            {
                var r = db.usp_Login(username).FirstOrDefault();
                if (r == null) return null;

                return new UserDto
                {
                    UserId = Convert.ToInt32(r.UserId),
                    Username = r.Username,
                    PasswordHash = r.PasswordHash,
                    Salt = r.Salt,
                    FullName = r.FullName,
                    RoleId = Convert.ToInt32(r.RoleId),
                    RoleName = r.RoleName,
                    IsActive = r.IsActive == true
                };
            }
        }

        // dbo.usp_User_TouchLogin
        public void TouchLogin(int userId)
        {
            using (var db = DbFactory.Create())
            {
                db.usp_User_TouchLogin(userId);
            }
        }
    }
}