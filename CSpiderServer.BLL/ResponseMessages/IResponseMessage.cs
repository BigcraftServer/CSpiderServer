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
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
        T Result { get; set; }
#pragma warning restore CS0108 // 成员隐藏继承的成员；缺少关键字 new
    }
}
