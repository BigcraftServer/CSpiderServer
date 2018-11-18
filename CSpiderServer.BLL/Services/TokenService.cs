using CSpiderServer.BLL.ResponseMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSpiderServer.BLL.Services
{
    public class TokenService
    {
        private DAL.CSpiderContext context;
        public TokenService(DAL.CSpiderContext context)
        {
            this.context = context;
        }
        public IResponseMessage Create(Models.RequestModels.User user)
        {
            DAL.Entities.User userEntity = user;
            if (context.Users.Any(c => c.Email.Equals(userEntity.Email, StringComparison.CurrentCultureIgnoreCase) && c.Password.Equals(userEntity.Password)))
            {
                DAL.Entities.UserToken userToken = new DAL.Entities.UserToken()
                {
                    Id = Guid.NewGuid().ToString(),
                    IsDeleted = false,
                    ExpireAt = DateTime.Now.AddDays(365),
                    UserId = userEntity.Id
                };
                context.UserTokens.Add(userToken);
                context.SaveChanges();
                return new SuccessMessage<Models.ResponseModels.UserToken>((Models.ResponseModels.UserToken)userToken);
            }
            return new FailureMessage();
        }
    }
}
