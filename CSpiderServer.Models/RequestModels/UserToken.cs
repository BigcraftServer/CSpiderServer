using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.RequestModels
{
    public class UserToken
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public static implicit operator Entities.UserToken(UserToken item)
        {
            return new Entities.UserToken()
            {
                Id = item.Id,
                UserId = item.UserId
            };
        }
    }
}
