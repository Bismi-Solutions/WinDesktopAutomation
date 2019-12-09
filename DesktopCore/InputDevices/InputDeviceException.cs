using System;
using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.InputDevices
{
    [Serializable]
    public class InputDeviceException : Exception
    {
        public InputDeviceException(string message) : base(message) { }
        public InputDeviceException(string message, Exception exception) : base(message, exception) { }
        protected InputDeviceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
