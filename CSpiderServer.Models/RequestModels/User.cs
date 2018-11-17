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

        public static implicit operator DAL.Entities.User(User user)
        {
            return new DAL.Entities.User()
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                Username = user.Username
            };
        }
    }
}
