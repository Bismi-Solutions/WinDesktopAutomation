using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.Scrolling {
    public class ComboBoxScrollBars : ScrollBars {
        public ComboBoxScrollBars(AutomationElement automationElement, ActionListener actionListener)
            : base(automationElement, actionListener, new DefaultScrollBarButtonAutomationIds(), new DefaultScrollBarButtonAutomationIds()) {}

        public override IHScrollBar Horizontal {
            get { return FindHorizontalBar(finder.Descendant); }
        }

        public override IVScrollBar Vertical {
            get { return FindVerticalBar(finder.Descendant); }
        }
    }
}