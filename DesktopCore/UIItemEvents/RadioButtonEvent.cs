using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class RadioButtonEvent : UserEvent
    {
        public RadioButtonEvent(IUIItem uiItem) : base(uiItem) {}

        protected override string ActionName(EventOption eventOption)
        {
            return MethodNameResolver.NameFor<RadioButton>(r=>r.Select());
        }
    }
}