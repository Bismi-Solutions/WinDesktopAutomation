using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class ListViewCell : Label
    {
        protected ListViewCell() {}
        public ListViewCell(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}
    }
}