using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSpiderServer.Models.RequestModels
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static implicit operator Entities.User(User item)
        {
            return new Entities.User()
            {
                Id = item.Id,
                Email = item.Email,
                Password = item.Password,
                Username = item.Username
            };
        }
    }
}
