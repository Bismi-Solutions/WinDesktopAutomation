using System;

namespace BismiSolutions.DesktopCore
{
    [Serializable]
    public class WhiteAssertionException : Exception
    {
        public WhiteAssertionException() { }
        public WhiteAssertionException(string message) : base(message) { }
        protected WhiteAssertionException(string message, Exception exception) : base(message, exception) { }
    }
}