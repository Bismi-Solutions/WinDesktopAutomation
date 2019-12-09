using System;
using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.Mappings
{
    [Serializable]
    public class ControlDictionaryException : Exception
    {
        public ControlDictionaryException(string message) : base(message) { }
        public ControlDictionaryException(string message, Exception exception) : base(message, exception) { }
        protected ControlDictionaryException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}