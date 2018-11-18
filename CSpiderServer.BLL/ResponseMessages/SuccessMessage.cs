using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public class SuccessMessage<T> : IResponseMessage<T> where T : class, new()
    {
        public SuccessMessage()
        {
            IsSucceed = true;
        }
        public SuccessMessage(T data) : this()
        {
            Result = data;
        }

        public SuccessMessage(T data, string message) : this(data)
        {
            Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }
        public bool IsSucceed { get; set; }
        object IResponseMessage.Result { get { return Result; } set { Result = (T)value; } }
    }
}
