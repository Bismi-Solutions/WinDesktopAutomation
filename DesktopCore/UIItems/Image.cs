using System.Windows.Automation;
using BismiSolutions.DesktopCore.Recording;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class Image : UIItem
    {
        protected Image() {}
        public Image(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public override void HookEvents(UIItemEventListener eventListener)
        {
            HookClickEvent(eventListener);
        }

        public override void UnHookEvents()
        {
            UnHookClickEvent();
        }
    }
}