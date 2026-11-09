using System;
using System.Linq;

namespace JOAMAPOS.Domain
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Manager = "Manager";
        public const string Cashier = "Cashier";
    }

    /// <summary>Message is safe to show to the user.</summary>
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }
    }

    public static class Session
    {
        public static UserDto CurrentUser { get; set; }

        public static bool IsLoggedIn
        {
            get { return CurrentUser != null; }
        }

        public static bool IsInRole(params string[] roles)
        {
            return CurrentUser != null && roles.Contains(CurrentUser.RoleName);
        }

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}