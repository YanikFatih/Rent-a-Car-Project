using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//success information with a message
        {
            Message = message;
        }

        public Result(bool success)//only success information
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
