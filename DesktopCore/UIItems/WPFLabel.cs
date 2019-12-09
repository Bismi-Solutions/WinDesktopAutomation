using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems
{
    [PlatformSpecificItem]
    public class WPFLabel : Label
    {
        protected WPFLabel() {}
        public WPFLabel(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual Hyperlink Hyperlink(string text)
        {
            return (Hyperlink) factory.Create(SearchCriteria.ByText(text).AndControlType(typeof (Hyperlink), Framework), actionListener);
        }
    }
}