﻿using System;
using System.Runtime.Serialization;

namespace _3C1GUILHERME13.Code.DAL
{
    [Serializable]
    internal class MySqlException : Exception
    {
        public MySqlException()
        {
        }

        public MySqlException(string message) : base(message)
        {
        }

        public MySqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MySqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}