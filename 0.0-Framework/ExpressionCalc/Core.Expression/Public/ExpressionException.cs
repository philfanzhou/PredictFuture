﻿using System;
using System.Runtime.Serialization;

namespace Core.Expression
{
    [Serializable]
    internal class ExpressionException : Exception
    {
        public ExpressionException()
        {
        }

        public ExpressionException(string message)
            : base(message)
        {
        }

        public ExpressionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ExpressionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
