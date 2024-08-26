using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.SessionManagement
{
    public class UserSession
    {
        private static UserSession _instance;

        public string Username { get; private set; }
        public int UserId { get; private set; }
        public string Role { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public void SetUser(string username, int userId, string role)
        {
            this.Username = username;
            this.UserId = userId;
            this.Role = role;
        }

        public void ClearUser()
        {
            this.Username = null;
            this.UserId = 0;
            this.Role = null;
        }

        public bool isLoggedIn()
        {
            return !string.IsNullOrEmpty(this.Username);
        }
    }
}
