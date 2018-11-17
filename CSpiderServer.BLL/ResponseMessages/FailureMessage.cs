using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public class FailureMessage : IResponseMessage
    {
        public FailureMessage()
        {
            Result = false;
        }

        public FailureMessage(string message) : this()
        {
            Message = message;
        }
        public FailureMessage(string message, object data) : this(message)
        {
            Data = data;
        }

        public object Data { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}
