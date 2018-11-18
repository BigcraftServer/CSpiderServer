using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.BLL.ResponseMessages
{
    public class FailureMessage : IResponseMessage
    {
        public FailureMessage()
        {
            IsSucceed = false;
        }

        public FailureMessage(string message) : this()
        {
            Message = message;
        }
        public FailureMessage(string message, object data) : this(message)
        {
            Result = data;
        }

        public object Result { get; set; }
        public string Message { get; set; }
        public bool IsSucceed { get; set; }
    }
}
