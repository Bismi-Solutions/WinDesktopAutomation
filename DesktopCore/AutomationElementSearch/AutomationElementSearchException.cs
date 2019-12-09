using System;
using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.AutomationElementSearch
{
    [Serializable]
    public class AutomationElementSearchException : Exception
    {
        public AutomationElementSearchException(string message) : base(message) { }
        public AutomationElementSearchException(string message, Exception innerException) : base(message, innerException) { }
        protected AutomationElementSearchException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
