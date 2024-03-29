using System.Windows;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Recording;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class Hyperlink : UIItem
    {
        protected Hyperlink() {}
        public Hyperlink(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual void Click(int xOffset, int yOffset)
        {
            double x = automationElement.Current.BoundingRectangle.X + xOffset;
            double y = automationElement.Current.BoundingRectangle.Y + yOffset;
            mouse.Click(new Point((int) x, (int) y), actionListener);
        }

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