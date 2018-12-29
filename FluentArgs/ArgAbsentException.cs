using System;
using System.Runtime.Serialization;

namespace FluentArgs
{
    [Serializable]
    public class ArgAbsentException : Exception
    {
        public static readonly string MessageFormat = "Argument '{0}' is absent.";
        
        public ArgAbsentException(string argName)
            : base(String.Format(MessageFormat, argName))
        {
            this.ArgName = argName;
        }
        
        public ArgAbsentException(string argName, Exception innerException)
            : base(String.Format(MessageFormat, argName), innerException)
        {
            this.ArgName = argName;
        }

        protected ArgAbsentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        public string ArgName { get; }
    }
}
