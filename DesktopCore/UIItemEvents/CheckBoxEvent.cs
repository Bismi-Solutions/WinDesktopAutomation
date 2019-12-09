using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class CheckBoxEvent : UserEvent
    {
        private readonly bool checkState;
        private static readonly string CachedActionName = PropertyResolver.NameFor((CheckBox c) => c.Checked);

        public CheckBoxEvent(CheckBox checkBox) : base(checkBox)
        {
            checkState = checkBox.Checked;
        }

        protected override string ActionName(EventOption eventOption)
        {
            return CachedActionName;
        }

        public override object[] ActionParameters
        {
            get { return new object[] {checkState}; }
        }
    }
}