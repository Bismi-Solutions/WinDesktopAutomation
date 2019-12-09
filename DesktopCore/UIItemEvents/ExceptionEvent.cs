using System;
using BismiSolutions.DesktopCore.UIItems;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class ExceptionEvent : UserEvent
    {
        private readonly Exception exception;

        public ExceptionEvent(IUIItem uiItem, Exception exception) : base(uiItem)
        {
            this.exception = exception;
        }

        protected override string ActionName(EventOption eventOption)
        {
            return exception.ToString();
        }
    }
}