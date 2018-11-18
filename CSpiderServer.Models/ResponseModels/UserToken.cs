using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.ResponseModels
{
    public class UserToken
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public static explicit operator UserToken(DAL.Entities.UserToken item)
        {
            return new UserToken()
            {
                Id = item.Id,
                UserId = item.UserId
            };
        }
    }
}
