using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public interface IResponseMessage
    {
        object Data { get; set; }
        string Message { get; set; }
        bool Result { get; set; }
    }
    public interface IResponseMessage<T> : IResponseMessage where T : class, new()
    {
        T Data { get; set; }
    }
}
