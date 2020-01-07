﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Api.Middlewares
{
    public class ExceptionResponse
    {
        public string Source { get; private set; }
        public string Message { get; private set; }
        public string StackTrace { get; private set; }

        public ExceptionResponse(Exception exception)
        {
            Source = exception.Source;
            Message = exception.Message;
            StackTrace = exception.StackTrace;
        }
    }
}
