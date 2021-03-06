﻿using CSpiderServer.BLL.ResponseMessages;
using CSpiderServer.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSpiderServer.BLL.Services
{
    public class UserService
    {
        private DAL.CSpiderContext context;
        public UserService(DAL.CSpiderContext context)
        {
            this.context = context;
        }
        public IResponseMessage Save(User user)
        {
            bool isExist = context.Users.Any(c => c.Email.Equals(user.Email));
            if (!isExist)
            {
                Models.Entities.User savedObject = user;
                savedObject.Id = Guid.NewGuid().ToString();
                var result = context.Users.Add(user);
                context.SaveChanges();
                return new SuccessMessage<Models.ResponseModels.User>((Models.ResponseModels.User)result.Entity);
            }
            else
            {
                return new FailureMessage();
            }
        }
    }
}
