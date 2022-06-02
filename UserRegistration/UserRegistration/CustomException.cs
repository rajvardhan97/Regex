using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        ExceptionType exceptionType;
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE
        }
        public CustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptionType = exception;
        }
    }
}