using System;
using System.Runtime.Serialization;

namespace ServerApiDependency.Utility.CustomException
{
    public class ServerApiFailException : Exception
    {
        public ServerApiFailException()
        {
            
        }

        public ServerApiFailException(string message) : base(message)
        {
        }

        public ServerApiFailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServerApiFailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}