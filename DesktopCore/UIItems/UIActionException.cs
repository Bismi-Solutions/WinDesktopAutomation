using System;
using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.UIItems
{
    //TODO: Change NUnit code to provide aspects, Checkout NUnit code and fix it
    [Serializable]
    public class UIActionException : Exception
    {
        public UIActionException(string message) : base(message) { }
        public UIActionException(string message, Exception innerException) : base(message, innerException) { }
        protected UIActionException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}