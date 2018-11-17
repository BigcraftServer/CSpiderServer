using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public class SuccessMessage<T> : IResponseMessage<T> where T : class, new()
    {
        public SuccessMessage()
        {
            Result = true;
        }
        public SuccessMessage(T data) : this()
        {
            Data = data;
        }

        public SuccessMessage(T data, string message) : this(data)
        {
            Message = message;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
        object IResponseMessage.Data { get { return Data; } set { Data = (T)value; } }
    }
}
