using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public interface IResponseMessage
    {
        object Result { get; set; }
        string Message { get; set; }
        bool IsSucceed { get; set; }
    }
    public interface IResponseMessage<T> : IResponseMessage where T : class, new()
    {
        T Result { get; set; }
    }
}
