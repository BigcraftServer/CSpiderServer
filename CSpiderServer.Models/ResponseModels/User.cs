using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.ResponseModels
{
    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public static explicit operator User(Entities.User item)
        {
            return new User()
            {
                Email = item.Email,
                Username = item.Username
            };
        }
    }
}
