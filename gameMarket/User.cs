using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameMarket
{
    public struct User
    {
        public string login { get; }
        public string password { get; }
        Role role { get; }

        public enum Role
        {
            ADMIN,
            USER
        }

        public User(string login, string password, Role role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }
}
