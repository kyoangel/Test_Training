using System;
using System.Runtime.Serialization;

namespace ServerApiDependency.Utility.CustomException
{
    public class AuthFailException : Exception
    {
        public AuthFailException()
        {
            
        }

        public AuthFailException(string message) : base(message)
        {
        }

        public AuthFailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuthFailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}