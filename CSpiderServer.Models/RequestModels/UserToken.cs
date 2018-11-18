using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.RequestModels
{
    public class UserToken
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public static implicit operator DAL.Entities.UserToken(UserToken item)
        {
            return new DAL.Entities.UserToken()
            {
                Id = item.Id,
                UserId = item.UserId
            };
        }
    }
}
