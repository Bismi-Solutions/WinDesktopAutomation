using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIA;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Scrolling;

namespace BismiSolutions.DesktopCore.UIItems.TableItems
{
    //TODO Table in scrolled position is not supported
    public class TableVerticalScrollBar : UIItem, IVScrollBar
    {
        private readonly TableVerticalScrollOffset offset;
        protected TableVerticalScrollBar() {}

        public TableVerticalScrollBar(AutomationElement automationElement, ActionListener actionListener, TableVerticalScrollOffset offset)
            : base(automationElement, actionListener)
        {
            this.offset = offset;
        }

        public virtual void ScrollUp()
        {
            mouse.Click(Bounds.ImmediateInteriorNorth(), actionListener);
        }

        public virtual void ScrollDown()
        {
            mouse.Click(Bounds.ImmediateInteriorSouth(), actionListener);
        }

        public virtual void ScrollUpLarge()
        {
            ScrollUp();
        }

        public virtual void ScrollDownLarge()
        {
            ScrollDown();
        }

        public virtual bool IsScrollable
        {
            get { return true; }
        }

        public virtual bool IsNotMinimum
        {
            get { return !offset.IsOnTop; }
        }

        public virtual double Value
        {
            get { return 0; }
        }

        public virtual double MinimumValue
        {
            get { return 0; }
        }

        public virtual double MaximumValue
        {
            get { return 100; }
        }

        public virtual void SetToMinimum()
        {
            while (IsNotMinimum)
            {
                ScrollUpLarge();
            }
        }

        public virtual void SetToMaximum() {}
    }
}