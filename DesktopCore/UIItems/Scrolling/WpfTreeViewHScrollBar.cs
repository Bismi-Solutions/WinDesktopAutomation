using System.Windows;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.Scrolling
{
    [PlatformSpecificItem(ReferAsType = typeof(IHScrollBar))]
    public class WpfTreeViewHScrollBar : WpfTreeViewScrollBar, IHScrollBar
    {
        private readonly ActionListener actionListener;

        public WpfTreeViewHScrollBar(AutomationElement parent, ActionListener actionListener)
            : base(parent)
        {
            this.actionListener = actionListener;
        }

        public override double Value
        {
            get { return ScrollPattern.Current.HorizontalScrollPercent; }
        }

        protected override double ScrollPercentage
        {
            get { return ScrollPattern.Current.HorizontalViewSize; }
        }

        public override Rect Bounds
        {
            get { return Rect.Empty; }
        }

        protected virtual void Scroll(ScrollAmount amount)
        {
            if (!IsScrollable) return;
            switch (amount)
            {
                case ScrollAmount.LargeDecrement:
                    ScrollPattern.SetScrollPercent(
                        ValidPercentage(ScrollPattern.Current.HorizontalScrollPercent - ScrollPercentage),
                        ScrollPattern.Current.VerticalScrollPercent);
                    break;
                case ScrollAmount.SmallDecrement:
                    ScrollPattern.SetScrollPercent(
                        ValidPercentage(ScrollPattern.Current.HorizontalScrollPercent - SmallPercentage()),
                        ScrollPattern.Current.VerticalScrollPercent);
                    break;
                case ScrollAmount.LargeIncrement:
                    ScrollPattern.SetScrollPercent(
                        ValidPercentage(ScrollPattern.Current.HorizontalScrollPercent + ScrollPercentage),
                        ScrollPattern.Current.VerticalScrollPercent);
                    break;
                case ScrollAmount.SmallIncrement:
                    ScrollPattern.SetScrollPercent(
                        ValidPercentage(ScrollPattern.Current.HorizontalScrollPercent + SmallPercentage()),
                        ScrollPattern.Current.VerticalScrollPercent);
                    break;
            }
            actionListener.ActionPerformed(Action.WindowMessage);
        }

        public virtual void ScrollLeft()
        {
            Scroll(ScrollAmount.SmallDecrement);
        }

        public virtual void ScrollRight()
        {
            Scroll(ScrollAmount.SmallIncrement);
        }

        public virtual void ScrollLeftLarge()
        {
            Scroll(ScrollAmount.LargeDecrement);
        }

        public virtual void ScrollRightLarge()
        {
            Scroll(ScrollAmount.LargeIncrement);
        }

        public virtual bool IsScrollable
        {
            get { return ScrollPattern.Current.HorizontallyScrollable; }
        }

        public override void SetToMinimum()
        {
            ScrollPattern.SetScrollPercent(0, ScrollPattern.Current.VerticalScrollPercent);
        }

        public override void SetToMaximum()
        {
            ScrollPattern.SetScrollPercent(100, ScrollPattern.Current.VerticalScrollPercent);
        }
    }
}