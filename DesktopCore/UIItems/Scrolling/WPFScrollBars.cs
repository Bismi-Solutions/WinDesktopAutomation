using System.Collections.ObjectModel;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.Scrolling
{
    public class WPFScrollBars : AbstractScrollBars
    {
        private readonly AutomationElement parentElement;
        private readonly ActionListener actionListener;

        public WPFScrollBars(AutomationElement parentElement, ActionListener actionListener)
        {
            this.parentElement = parentElement;
            this.actionListener = actionListener;
        }

        public override IHScrollBar Horizontal
        {
            get
            {
                var patterns = new Collection<AutomationPattern>(parentElement.GetSupportedPatterns());
                return patterns.Contains(ScrollPattern.Pattern)
                           ? (IHScrollBar)new WpfHScrollBar(parentElement, actionListener)
                           : new NullHScrollBar();
            }
        }

        public override IVScrollBar Vertical
        {
            get
            {
                var patterns = new Collection<AutomationPattern>(parentElement.GetSupportedPatterns());
                return patterns.Contains(ScrollPattern.Pattern)
                           ? (IVScrollBar)new WpfVScrollBar(parentElement, actionListener)
                           : new NullVScrollBar();
            }
        }

        public override bool CanScroll
        {
            get { return Horizontal.IsScrollable || Vertical.IsScrollable; }
        }
    }
}