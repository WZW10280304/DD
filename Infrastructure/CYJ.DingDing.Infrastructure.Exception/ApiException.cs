using CYJ.DingDing.Dto.Enum;
using System;
using System.Runtime.Serialization;

namespace CYJ.DingDing.Infrastructure.Exception
{
    [Serializable]
    public class ApiException : ApplicationException
    {
        public ApiException() : base()
        {

        }

        public ApiException(ApiCodeEnum code, string message) : base(message)
        {

        }

        public ApiException(ApiCodeEnum code, string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
